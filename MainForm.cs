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

        public MainWindowForm()
        {
            InitializeComponent();
            this.CA = new CellularAutomata();

            space_dim = System.Convert.ToInt32(numericUpDown_dimension.Value);
            Console.WriteLine(Convert.ToString(getNeighborhoodType()));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            space_display.Image = resizeImage(CA.grow(current_state).grains_bmp, 150, 150);
        }

        private void button_generate_initial_space(object sender, EventArgs e)
        {
            Console.WriteLine("[MainForm.cs] button_generate_initial_space()");
            previous_state = new State(50);
            current_state = new State(50);
            previous_state.initState(1);
            previous_state.updateState(previous_state);
            space_display.Image = resizeImage(previous_state.grains_bmp, 150, 150);
        }

        private void button_proceed_single_iteration(object sender, EventArgs e)
        {
            Console.WriteLine("[MainForm.cs] button_proceed_single_iteration()");
            current_state.grains_structure = current_state.updateGrainsStructure2(previous_state);
            current_state.updateState(current_state);
            space_display.Image = resizeImage(current_state.grains_bmp, 150, 150);

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

        int[,] test_state = new int[3, 3];

        private void button2_Click(object sender, EventArgs e)
        {

            for (var i=0; i<test_state.GetLength(0); ++i)
            {
                for (var j = 0; j < test_state.GetLength(1); ++j)
                {
                    test_state[i, j] = 0;
                }
            }
            test_state[1, 1] = 1;

            List<int> IDs = new List<int>();
            IDs.Add(1);
           // var current_state = TickAlgorithm(test_state.GetLength(1), IDs);

            //for (var i = 0; i < test_state.GetLength(0); ++i)
            //{       
            //    for (var j = 0; j < test_state.GetLength(1); ++j)
            //    {
            //        //Console.WriteLine("Element [{0},{1}]:{2}, number of neighbors:{3}",i,j,test_state[i, j], getNumberOfNeighbors(i,j, test_state.GetLength(0),1, test_state,false) );
            //        //Console.WriteLine("Element [{0},{1}]:{2}", i, j, test_state[i, j]);
            //        Console.WriteLine("Element [{0},{1}]:{2}", i, j, current_state[i, j]);

            //    }
            //    Console.Write(Environment.NewLine + Environment.NewLine);
            //}

     
    }



    //public int[,] TickAlgorithm(int dim, List<int> IDs, int [,] previous_state = null)
    //{
    //    int[,] current_state = new int[dim, dim];

    //    for (int x = 0; x < dim; ++x)
    //    {
    //        for (int y = 0; y < dim; ++y)
    //        {
    //            List<int> state_for_xy_coordinates = new List<int>();
    //            foreach (var id in IDs)
    //            {
    //                    state_for_xy_coordinates.Add(getNumberOfNeighbors(x, y, test_state.GetLength(0), 1, test_state, false));
    //            }
    //                if (state_for_xy_coordinates.Max() == 0 && test_state[x, y] == 0)
    //                {
    //                    current_state[x, y] = 0;
    //                }
    //                else if (state_for_xy_coordinates.Max() == 0 && test_state[x, y] != 0)
    //                {
    //                    current_state[x, y] = test_state[x,y];
    //                }
    //                else
    //                {
    //                    current_state[x, y] = state_for_xy_coordinates.Max();
    //                }

    //            }
    //    }
    //    return current_state;
    //}



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
