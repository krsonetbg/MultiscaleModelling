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
        private CellularAutomata CA;


        public enum neighborhood_type {VonNeumann=0, Moore=1};
        private Random rand;
        private double image_scaling_factor;

        public MainWindowForm()
        {
            InitializeComponent();
            this.CA = new CellularAutomata();

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
            previous_state.initState(grains_number);
            previous_state.updateState(previous_state);
            int scaled_dim = 300;
            space_display.Image = resizeImage(previous_state.grains_bmp, scaled_dim, scaled_dim);
            image_scaling_factor = dim /(double)scaled_dim;
            //space_display.Image = previous_state.grains_bmp;

        }

        private void button_proceed_single_iteration(object sender, EventArgs e)
        {
                Console.WriteLine("[MainForm.cs] button_proceed_single_iteration()");
                current_state.grains_structure = current_state.updateGrainsStructure2(previous_state);
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
            do
            {
                Console.WriteLine("[MainForm.cs] button_proceed_single_iteration()");
                current_state.grains_structure = current_state.updateGrainsStructure2(previous_state);
                current_state.updateState(current_state);
                space_display.Image = resizeImage(current_state.grains_bmp, 300, 300);
                //space_display.Image = current_state.grains_bmp;

                previous_state = current_state;
                System.Threading.Thread.Sleep(10);
                Console.WriteLine("Waiting...\n");
                space_display.Refresh();
            } while (!current_state.isStructureFull());
        }

        private void importDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("[MainForm.cs] import_data...");
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Load data from file";
            ofd.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (ofd.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void exportDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("[MainForm.cs] export_data...");
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save data";
            sfd.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (sfd.ShowDialog() == DialogResult.OK)
            { 
                FileWriter.SaveGrainStructureTxt(current_state);
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
            previous_state.addInclusion(center, 'c');
            previous_state.updateState(previous_state);
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
