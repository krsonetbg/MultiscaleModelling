using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiscaleModelling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button clicked...");
            int dim = 150;
            Bitmap bmp = new Bitmap(dim, dim);
            for (int y = 0; y<dim; y++)
            {
                for (int x=0; x<dim; x++)
                {
                    bmp.SetPixel(y, x, Color.ForestGreen);
                }
            }
            space_display.Image = bmp;

        }
    }
}
