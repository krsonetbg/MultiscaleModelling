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

//TODO
// Implement stucture loading from .bmp file.
// Add possibility to configure file name for data to be saved.
// Implement extended algorithm rules. 

//TOPRESENT 
// Fixed generation of initial grain structure, it is ensured now, that correct number of grains is generated, they are generated in a while loop.
// Furthermore one cannot create more grains then dimension*dimension.
// Added automatic grain generation based on GUI and new button.


namespace MultiscaleModelling
{
    public partial class MainWindowForm : Form
    {
        private State previous_state, current_state;
        private int space_dim;
        private CellularAutomata CA;
        private bool growth_complete = false;
        private bool extended_CA_algorithm = false;

        public enum neighborhood_type {VonNeumann=0, Moore=1};
        private Random rand = new Random();
        private double image_scaling_factor;

        public MainWindowForm()
        {
            InitializeComponent();
            //this.CA = new CellularAutomata();

            space_dim = System.Convert.ToInt32(numericUpDown_dimension.Value);
            Console.WriteLine(Convert.ToString(getNeighborhoodType()));
        }




        private void button_generate_initial_space(object sender, EventArgs e)
        {
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
                current_state.grains_structure = current_state.updateGrainsStructure(previous_state);
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
            if (extended_CA_algorithm)
            {
                do
                {
                    Console.WriteLine("[MainForm.cs] button_proceed_single_iteration()");
                    current_state.grains_structure = current_state.updateGrainsStructureExtendedCA(previous_state);
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
                    Console.WriteLine("[MainForm.cs] button_proceed_single_iteration()");
                    current_state.grains_structure = current_state.updateGrainsStructure(previous_state);
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
            for (var i = 0; i < number_of_inclusions; ++i)
            {
                
                if (comboBox_inclusions.SelectedItem != null)
                {
                    if (growth_complete == false)
                    {
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

                previous_state.generateStructure(number_of_grains_in_structure ,structure_type);
                


                //previous_state.initState(0);
                //previous_state.updateState(previous_state);
                //space_display.Image = resizeImage(previous_state.grains_bmp, 300, 300);
                //space_display.Refresh();
            }
        }

        private neighborhood_type getNeighborhoodType()
    {
        if (radioButton_Moore.Checked == true)
        {
            return neighborhood_type.Moore;
        }
        else
        {
            return neighborhood_type.VonNeumann;
        }
    }

    }
}
