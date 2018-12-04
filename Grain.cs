using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MultiscaleModelling
{
    public class Grain
    {
        public int ID { get; set; }
        public int phase { get; set; }
        public Color color { get; set; }
        public int H { get; set; }
        public Grain(){ }
        public Grain(int id, int p, Color c, int energy =5)
        {
            ID = id;
            phase = p;
            color = c;
            H = energy;
        }
    }
}
