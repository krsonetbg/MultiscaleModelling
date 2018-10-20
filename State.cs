using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace MultiscaleModelling
{
    public class State
    {
        public int dimension { get; set; }
        public Grain[,] grains_structure { get; set; }
        public Bitmap grains_bmp;
        public static Random rand = new Random();
        static Dictionary<int, Color> grain_ID_Color_dict = new Dictionary<int, Color>();
        //public List<>

        public State() { }
        public State(int dim)
        {
            grains_structure = new Grain[dim, dim];
            grains_bmp = new Bitmap(dim, dim);
            dimension = dim;
        }

        private int getNumberOfNeighbors(int x, int y, int dim, int id, Grain[,] space, bool neighborhood_type = false)
        {
            // Returns the number of neighbors with particular id for a specific coordinate
            // VonNeumann neighborhood
            int neighbors = 0;
            if (x + 1 < dim && space[x + 1, y].ID == id)
            {
                neighbors++;
            }
            if (x - 1 >= 0 && space[x - 1, y].ID == id)
            {
                neighbors++;
            }
            if (y + 1 < dim && space[x, y + 1].ID == id)
            {
                neighbors++;
            }
            if (y - 1 >= 0 && space[x, y - 1].ID == id)
            {
                neighbors++;
            }
            if (neighborhood_type)
            {
                // Moore neighborhood
                // diaganals
                if (x + 1 < dim && y + 1 < dim && space[x + 1, y + 1].ID == id)
                {
                    neighbors++;
                }
                if (x + 1 < dim && y - 1 >= 0 && space[x + 1, y - 1].ID == id)
                {
                    neighbors++;
                }
                if (x - 1 >= 0 && y + 1 < dim && space[x - 1, y + 1].ID == id)
                {
                    neighbors++;
                }
                if (x - 1 >= 0 && y - 1 >= 0 && space[x - 1, y - 1].ID == id)
                {
                    neighbors++;
                }
            }

            return neighbors;
        }



        public Grain[,] updateGrainsStructure(State state)
        {

            Grain[,] current_grains_structure = new Grain[state.dimension, state.dimension];//state.grains_structure;
            initGrainStructure(out current_grains_structure, state.dimension);

            for (int x = 0; x < state.dimension; ++x)
            {
                for (int y = 0; y < state.dimension; ++y)
                {
                    List<int> state_for_xy_coordinates = new List<int>();

                    if (state.grains_structure[x, y].ID == 0) // Cell is empty, no viable grain is there
                    {
                        foreach (var item in grain_ID_Color_dict)
                        {
                            if (item.Key != 0 && item.Key != -1) // Count only non-zero neighbors, do not count inclusions
                                state_for_xy_coordinates.Add(getNumberOfNeighbors(x, y, state.grains_structure.GetLength(0), item.Key, state.grains_structure, false));
                        }

                        if (state_for_xy_coordinates.Max() == 0 && state.grains_structure[x, y].ID == 0)
                        {
                            current_grains_structure[x, y] = new Grain(0, 0, grain_ID_Color_dict[0]);
                        }

                        else
                        {
                            int grain_id = state_for_xy_coordinates.IndexOf(state_for_xy_coordinates.Max()) + 1; // +1, because first ID to be considered is 1, but first element added to list has index 0 

                            // What if there is more, than one max value? TODO
                            // var max_indices =
                            // state_for_xy_coordinates.Select((n, i) => new { n, i }).GroupBy(p => p.n, p => p.i).OrderByDescending(p => p.Key).Take(1).SelectMany(p => p).ToArray();
                            // int grain_id = state_for_xy_coordinates[rand.Next(0, max_indices.Length)]+1;

                            Color c = grain_ID_Color_dict[grain_id];
                            //current_grains_structure[x, y] = new Grain(state_for_xy_coordinates.Max(), 0, c);
                            current_grains_structure[x, y] = new Grain(grain_id, 0, c);

                        }
                    }
                    else
                    {
                        current_grains_structure[x, y] = state.grains_structure[x, y];
                    } // state.grains_structure[x, y].ID != 0, so rewrite previous ID

                }
            }

            return current_grains_structure;
        }


        private void updateGrainsBMP(State state)
        {
            if (state != null)
            {
                state.grains_bmp = new Bitmap(state.dimension, state.dimension);

                if (state.grains_structure != null)
                {
                    for (int i = 0; i < state.dimension; i++)
                    {
                        for (int j = 0; j < state.dimension; j++)
                        {
                            state.grains_bmp.SetPixel(i, j, state.grains_structure[i, j].color);

                            if (state.grains_structure[i, j].ID == -1)
                            {
                                var t = true;
                            }
                        }
                    }
                }
            }
        }

        private void updateGrainsBMP()
        {
            if (this != null)
            {
                this.grains_bmp = new Bitmap(this.dimension, this.dimension);

                if (this.grains_structure != null)
                {
                    for (int i = 0; i < this.dimension; i++)
                    {
                        for (int j = 0; j < this.dimension; j++)
                        {
                            this.grains_bmp.SetPixel(i, j, this.grains_structure[i, j].color);

                            if (this.grains_structure[i, j].ID == -1)
                            {
                                var t = true;
                            }
                        }
                    }
                }
            }
        }


        public void updateState(State state)
        {
            //updateGrainsStructure(state);
            updateGrainsBMP();
        }

        public void initState(int number_of_grains)
        {
            clearState();
            for (int y = 0; y < this.dimension; y++)
            {
                for (int x = 0; x < this.dimension; x++)
                {
                    this.grains_structure[y, x] = new Grain(0, 0, Color.Wheat);
                }
            }
            grain_ID_Color_dict.Add(0, Color.Wheat);
            grain_ID_Color_dict.Add(-1, Color.Black);

            for (int i = 1; i <= number_of_grains; ++i)
            {
                Color c = Color.FromArgb(rand.Next(10, 256), rand.Next(10, 256), 0);
                this.grains_structure[rand.Next(0, this.dimension - 1), rand.Next(0, this.dimension - 1)] = new Grain(i, 0, c);
                grain_ID_Color_dict.Add(i, c);
            }

        }

        public void clearState()
        {
            grains_structure = new Grain[this.dimension, this.dimension];
            grains_bmp = new Bitmap(this.dimension, this.dimension);
            grain_ID_Color_dict.Clear();
        }

        private void initGrainStructure(out Grain[,] g_s, int dim)
        {
            g_s = new Grain[dim, dim];
            for (int x = 0; x < dim; ++x)
            {
                for (int y = 0; y < dim; ++y)
                {
                    g_s[x, y] = new Grain(0, 0, grain_ID_Color_dict[0]);
                }
            }
        }

        public void addInclusion(Tuple<int,int> inclusion_center, char inclusion_type = 'c')
        {
            Tuple<int, int> validated_center =  StateHelper.validateAndAdjustPointCoordinates(inclusion_center,this.dimension);
            this.grains_structure[validated_center.Item1, validated_center.Item2] =  new Grain(-1, 0, Color.Black);
        }


        public bool isStructureFull()
        {

            for (int x = 0; x < this.dimension; ++x)
            {
                for (int y = 0; y < dimension;  ++y)
                {
                    if (grains_structure[x, y].ID == 0) return false;               
                }
            }

            return true;
        }
    }
}
