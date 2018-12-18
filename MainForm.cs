using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace MultiscaleModelling
{
    public partial class MainWindowForm : Form
    {
        private State previous_state, current_state;
        private int space_dim;
        private bool growth_complete = false;
        private bool extended_CA_algorithm = false;

        private Random rand = new Random();
        private double image_scaling_factor;

        public MainWindowForm()
        {
            InitializeComponent();
            //this.CA = new CellularAutomata();

            space_dim = System.Convert.ToInt32(numericUpDown_dimension.Value);
        }




        private void button_generate_initial_space(object sender, EventArgs e)
        {
            button_growth.Enabled = true;
            button_single_iteration.Enabled = true;
            Console.WriteLine("[MainForm.cs] button_generate_initial_space()");
            int dim = Convert.ToInt32(numericUpDown_dimension.Value);
            previous_state = new State(dim);
            current_state = new State(dim);
            int grains_number = Convert.ToInt32(numericUpDown_number_of_grains.Value);
            if (grains_number >= dim * dim) return;
            previous_state.initState(grains_number);
            previous_state.updateState(previous_state);
            int scaled_dim = 300;
            //State.setNeighborhoodType(getNeighborhoodType());
            space_display.Image = resizeImage(previous_state.grains_bmp, scaled_dim, scaled_dim);
            image_scaling_factor = dim /(double)scaled_dim;
            //space_display.Image = previous_state.grains_bmp;

        }

        private void button_proceed_single_iteration(object sender, EventArgs e)
        {
                Console.WriteLine("[MainForm.cs] button_proceed_single_iteration()");
                string neighborhood_type = radioButton_Moore.Checked ? "MooreClassic" : "VonNeumann";
                current_state.grains_structure = current_state.updateGrainsStructure(previous_state, neighborhood_type);
                current_state.updateState(current_state);
                space_display.Image = resizeImage(current_state.grains_bmp, 300, 300);
                previous_state = current_state;
        }

        public static Bitmap resizeImage(Image image, int width, int height)
        {
            var destination_rectangle = new Rectangle(0, 0, width, height);
            var destination_image = new Bitmap(width, height);

            destination_image.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destination_image))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                //graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.Half;

                using (var wrap_mode = new ImageAttributes())
                {
                    wrap_mode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destination_rectangle, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrap_mode);
                }
            }

            return destination_image;
        }

        private void button_growth_Click(object sender, EventArgs e)
        {
            extended_CA_algorithm = radioButton_extended_CA.Checked;
            if (extended_CA_algorithm)
            {
                do
                {
                    Console.WriteLine("[MainForm.cs] button_growth_Click()");
                    int prob = Convert.ToInt32(numericUpDown_probability.Value);
                    current_state.grains_structure = previous_state.updateGrainsStructureExtendedCA(previous_state, prob);
                    current_state.updateState(current_state);
                    space_display.Image = resizeImage(current_state.grains_bmp, 300, 300);
                    //space_display.Image = current_state.grains_bmp;

                    previous_state = current_state;
                    System.Threading.Thread.Sleep(1);
                    space_display.Refresh();
                } while (!current_state.isStructureFull());
            }
            else
            {
                do
                {
                    Console.WriteLine("[MainForm.cs] button_growth_Click()");
                    string neighborhood_type = radioButton_Moore.Checked ? "MooreClassic" : "VonNeumann";
                    current_state.grains_structure = current_state.updateGrainsStructure(previous_state, neighborhood_type);
                    current_state.updateState(current_state);
                    space_display.Image = resizeImage(current_state.grains_bmp, 300, 300);
                    //space_display.Image = current_state.grains_bmp;

                    previous_state = current_state;
                    System.Threading.Thread.Sleep(1);
                    space_display.Refresh();
                } while (!current_state.isStructureFull());
            }

            growth_complete = true;
            updateGUI();

        }

        private void importDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("[MainForm.cs] import_data...");
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Load data from file";
            ofd.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string input_file_name = ofd.FileName;
                string extension = Path.GetExtension(input_file_name);

                if (extension.Equals(".txt"))
                {
                    previous_state = FileReader.ReadTxtFile(input_file_name);
                    previous_state.updateState(previous_state);
                    current_state = previous_state;
                }
                else if (extension.Equals(".bmp"))
                {
                    previous_state = FileReader.ReadBitmapFile(input_file_name);
                    //previous_state.updateState(previous_state);
                    current_state = previous_state;
                    growth_complete = true;
                    updateGUI();
                }
                else
                {
                    return;
                }
                space_display.Image = resizeImage(current_state.grains_bmp, 300, 300);
                space_display.Refresh();
            }
        }

        private void exportDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("[MainForm.cs] export_data...");
            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Title = "Save data";
            //sfd.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //if (sfd.ShowDialog() == DialogResult.OK)
            //{ 
            //    FileWriter.SaveGrainStructureTxt(current_state);
            //}
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("Folder browser dialog OK clicked...");
                Console.WriteLine(fbd.SelectedPath);
                string path = fbd.SelectedPath;
                FileWriter.SaveGrainStructureBMP(current_state, path);
                FileWriter.SaveGrainStructureTxt(current_state, path);

            }

        }

        private void space_display_Click(object sender, EventArgs e)
        {
            // Capture mouse coordinates on space to add inclusions
            var mouseEventArgs = e as MouseEventArgs;
            if (mouseEventArgs != null) Console.WriteLine("X= " + mouseEventArgs.X + " Y= " + mouseEventArgs.Y);
            var x = Convert.ToInt32(this.image_scaling_factor * mouseEventArgs.X);
            var y = Convert.ToInt32(this.image_scaling_factor * mouseEventArgs.Y);
            Tuple<int, int>  center = new Tuple<int, int>(x,y);
            int inclusion_size = Convert.ToInt32(numericUpDown_inclusion_size.Value);
            if (comboBox_inclusions.SelectedItem != null)
                {
                    if (growth_complete == false)
                {
                    char inclusion_type = Convert.ToChar(comboBox_inclusions.SelectedItem.ToString()[0]);
                    inclusion_type = char.ToLower(inclusion_type);
                    previous_state.addInclusion(center, inclusion_size, inclusion_type);
                    previous_state.updateState(previous_state);
                    space_display.Image = resizeImage(previous_state.grains_bmp, 300, 300);
                    space_display.Refresh();
                }
                else
                {
                    if (StateHelper.isPointOnGrainBorder(center, previous_state.grains_structure))
                    {
                        char inclusion_type = Convert.ToChar(comboBox_inclusions.SelectedItem.ToString()[0]);
                        inclusion_type = char.ToLower(inclusion_type);
                        previous_state.addInclusion(center, inclusion_size, inclusion_type);
                        previous_state.updateState(previous_state);
                        space_display.Image = resizeImage(previous_state.grains_bmp, 300, 300);
                        space_display.Refresh();
                    }
                }
            }
               
        }

        private void button_generate_inclusions_Click(object sender, EventArgs e)
        {

            int inclusion_size = Convert.ToInt32(numericUpDown_inclusion_size.Value);
            int number_of_inclusions = Convert.ToInt32(numericUpDown_number_of_inclusions.Value);
            space_dim = System.Convert.ToInt32(numericUpDown_dimension.Value);

            for (var i = 0; i < number_of_inclusions; ++i)
            {
                
                if (comboBox_inclusions.SelectedItem != null)
                {
                    if (growth_complete == false)
                    {
                        var t = previous_state.grains_structure.GetLength(0);
                        var x = rand.Next(0, space_dim - 1);
                        var y = rand.Next(0, space_dim - 1);
                        while (previous_state.grains_structure[x, y].ID == 0 && previous_state.grains_structure[x, y].ID == -1)
                        {
                            x = rand.Next(0, space_dim - 1);
                            y = rand.Next(0, space_dim - 1);
                        };
                        Tuple<int, int> center = new Tuple<int, int>(x, y);

                        char inclusion_type = Convert.ToChar(comboBox_inclusions.SelectedItem.ToString()[0]);
                        inclusion_type = char.ToLower(inclusion_type);
                        previous_state.addInclusion(center, inclusion_size, inclusion_type);
                        previous_state.updateState(previous_state);
                        space_display.Image = resizeImage(previous_state.grains_bmp, 300, 300);
                        space_display.Refresh();
                    }
                    else
                    {
                        Tuple<int, int> center;
                        do
                        {
                            var t = previous_state.grains_structure.GetLength(0);
                            var x = rand.Next(0, space_dim - 1);
                            var y = rand.Next(0, space_dim - 1);
                            while (previous_state.grains_structure[x, y].ID == 0 && previous_state.grains_structure[x, y].ID == -1)
                            {
                                x = rand.Next(0, space_dim - 1);
                                y = rand.Next(0, space_dim - 1);
                            };
                            center = new Tuple<int, int>(x, y);
                        } while (StateHelper.isPointOnGrainBorder(center, previous_state.grains_structure) == false);
                        
                            char inclusion_type = Convert.ToChar(comboBox_inclusions.SelectedItem.ToString()[0]);
                            inclusion_type = char.ToLower(inclusion_type);
                            previous_state.addInclusion(center, inclusion_size, inclusion_type);
                            previous_state.updateState(previous_state);
                            space_display.Image = resizeImage(previous_state.grains_bmp, 300, 300);
                            space_display.Refresh();
                        
                    }
                }
            }

            
        }

        private void updateGUI()
        {
            if (growth_complete)
            {
                button_generate_structure.Enabled = true;
            }
        }

        private void button_generate_structure_Click(object sender, EventArgs e)
        {
            if (comboBox_structure_type.SelectedItem != null)
            {
                var number_of_grains_in_structure = Convert.ToInt32(numericUpDown_structure_grain_number.Value);
                char structure_type = Convert.ToChar(comboBox_structure_type.SelectedItem.ToString()[0]);
                structure_type = char.ToLower(structure_type);

                current_state.generateStructure(number_of_grains_in_structure ,structure_type);


                current_state.updateState(current_state);
                space_display.Image = resizeImage(current_state.grains_bmp, 300, 300);
                space_display.Refresh();
                growth_complete = false;
            }
        }

        private void radioButton_extended_CA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_extended_CA.Checked)
            {
                numericUpDown_probability.Enabled = true;
                radioButton_Moore.Enabled = false;
                radioButton_Von_Neumann.Enabled = false;
            }
        }

        private void button_generate_new_grains_Click(object sender, EventArgs e)
        {
            if (numericUpDown_new_grains.Value > 0)
            {
                current_state.addGrainsToExistingStructure(Convert.ToInt32(numericUpDown_new_grains.Value));
            }

            current_state.updateState(current_state);
            //previous_state.grains_structure = current_state.grains_structure;
            previous_state = current_state;
            space_display.Image = resizeImage(current_state.grains_bmp, 300, 300);
            space_display.Refresh();
        }

        private void button_generate_border_Click(object sender, EventArgs e)
        {            
            var grain_boundaries = StateHelper.findGrainBoundaries(current_state.grains_structure);
            int width = current_state.grains_structure.GetLength(0);
            int height = width;
            space_display.Image = resizeImage(StateHelper.getGrainBoundariesImage(grain_boundaries, width, height), 300, 300);
            System.Threading.Thread.Sleep(1);
            space_display.Refresh();
        }

        private void button_mc_method_Click(object sender, EventArgs e)
        {
            int number_of_iterations = Convert.ToInt32(numericUpDown_MC_iterations.Value);
            var counter = 0;
            do
            {
                current_state.grains_structure = previous_state.updateGrainsStructureMC(previous_state);
                current_state.updateState(current_state);
                space_display.Image = resizeImage(current_state.grains_bmp, 300, 300);
                //space_display.Image = current_state.grains_bmp;

                previous_state = current_state;
                System.Threading.Thread.Sleep(1);
                space_display.Refresh();
                Console.WriteLine("Monte Carlo iteration: {0}", counter);
                ++counter;               
            } while (counter < number_of_iterations);
            

            growth_complete = true;
            updateGUI();
        }

        private void button_init_space_mc_Click(object sender, EventArgs e)
        {
            button_growth.Enabled = true;
            button_single_iteration.Enabled = true;

            int dim = Convert.ToInt32(numericUpDown_dimension.Value);
            previous_state = new State(dim);
            current_state = new State(dim);
            int grains_number = Convert.ToInt32(numericUpDown_number_of_grains.Value);
            previous_state.initStateMonteCarlo(grains_number);

            //int dim = 3;
            //previous_state = new State(dim);
            //current_state = new State(dim);
            //previous_state.initStateMonetCarloDEBUG();

            previous_state.updateState(previous_state);
            int scaled_dim = 300;
            space_display.Image = resizeImage(previous_state.grains_bmp, scaled_dim, scaled_dim);
            //image_scaling_factor = dim / (double)scaled_dim;
            //space_display.Image = previous_state.grains_bmp;
        }

        private void button_generate_new_grains_for_MC_Click(object sender, EventArgs e)
        {
            if (numericUpDown_new_grains.Value > 0)
            {
                current_state.addGrainsToExistingStructureMC(Convert.ToInt32(numericUpDown_new_grains.Value));
            }
            current_state.updateState(current_state);
            //previous_state.grains_structure = current_state.grains_structure;
            previous_state = current_state;
            space_display.Image = resizeImage(current_state.grains_bmp, 300, 300);
            space_display.Refresh();
        }

        private void button_energy_distribution_display_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Show();
            bool heterogeneous = checkBox_heterogeneous.Checked;
            int width = current_state.grains_structure.GetLength(0);
            int height = width;
            int internal_energy = Convert.ToInt32(numericUpDown_internal_energy.Value);
            int grain_boundaries_energy = Convert.ToInt32(numericUpDown_grain_boundaries_energy.Value);
            current_state.calculateEnergyDistribution(current_state.grains_structure, width, height, internal_energy, grain_boundaries_energy, heterogeneous);
            var energy_distribution_image = current_state.getEnergyDistributionPicture(current_state.grains_structure, width, height, internal_energy, grain_boundaries_energy);
            PictureBox pb = new PictureBox
            {
                Image = energy_distribution_image,
                Size = form.Size,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            form.Controls.Add(pb);
        }

        private void checkBox_heterogeneous_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_heterogeneous.Checked)
                numericUpDown_grain_boundaries_energy.Enabled = true;
            else
                numericUpDown_grain_boundaries_energy.Enabled = false;
        }

        private void button_generate_nucleons_Click(object sender, EventArgs e)
        {
            if (numericUpDown_nucleons_number.Value > 0)
            {
                current_state.addNucleonsToExistingStructure(Convert.ToInt32(numericUpDown_nucleons_number.Value));
            }
            Console.WriteLine("Nucleons generated!");
            current_state.updateState(current_state);
            Console.WriteLine("State updated!");
            //previous_state.grains_structure = current_state.grains_structure;
            previous_state = current_state;
            space_display.Image = resizeImage(current_state.grains_bmp, 300, 300);
            space_display.Refresh();
            Console.WriteLine("Display refreshed!");
        }

        private void button_grow_recrystalized_Click(object sender, EventArgs e)
        {
            int number_of_iterations = Convert.ToInt32(numericUpDown_MC_iterations.Value);
            var counter = 0;
            do
            {
                current_state.grains_structure = previous_state.updateGrainsStructureMC(previous_state, true);
                current_state.updateState(current_state);
                space_display.Image = resizeImage(current_state.grains_bmp, 300, 300);
                //space_display.Image = current_state.grains_bmp;

                previous_state = current_state;
                System.Threading.Thread.Sleep(1);
                space_display.Refresh();
                Console.WriteLine("Monte Carlo iteration: {0}", counter);
                ++counter;
            } while (counter < number_of_iterations);
        }

        private void radioButton_classic_CA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_classic_CA.Checked)
            {
                numericUpDown_probability.Enabled = false;
                radioButton_Moore.Enabled = true;
                radioButton_Von_Neumann.Enabled = true;
            }
        }

        

    }
}
