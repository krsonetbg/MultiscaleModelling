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
        public Grain[,] grains_structure { get; set;}
        public Bitmap grains_bmp;
        public static Random rand = new Random();
        static List<int> grain_IDs = new List<int>();

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


        public void updateGrainsStructure(State state)
        {
            List<int> IDs = new List<int>();
            IDs.Add(1);
            Grain[,] current_grains_structure = state.grains_structure;

            for (int x = 0; x < state.dimension; ++x)
            {
                for (int y = 0; y < state.dimension; ++y)
                {
                    List<int> state_for_xy_coordinates = new List<int>();
                    foreach (var id in IDs)
                    {
                        state_for_xy_coordinates.Add(getNumberOfNeighbors(x, y, state.grains_structure.GetLength(0), id, state.grains_structure, false));
                    }
                    if (state_for_xy_coordinates.Max() == 0 && state.grains_structure[x, y].ID == 0)
                    {
                        current_grains_structure[x, y].ID = 0;
                    }
                    else if (state_for_xy_coordinates.Max() == 0 && state.grains_structure[x, y].ID != 0)
                    {
                        current_grains_structure[x, y].ID = state.grains_structure[x, y].ID;
                    }
                    else
                    {
                        current_grains_structure[x, y].ID = state_for_xy_coordinates.Max();
                    }

                }
            }

            state.grains_structure = current_grains_structure;
        }

        public Grain[,] updateGrainsStructure2(State state)
        {
            List<int> IDs = new List<int>();
            IDs.Add(1);
            //Grain[,] current_grains_structure = new Grain[state.dimension, state.dimension];
            Grain[,] current_grains_structure = state.grains_structure;

            for (int x = 0; x < state.dimension; ++x)
            {
                for (int y = 0; y < state.dimension; ++y)
                {
                    List<int> state_for_xy_coordinates = new List<int>();
                    foreach (var id in IDs)
                    {
                        state_for_xy_coordinates.Add(getNumberOfNeighbors(x, y, state.grains_structure.GetLength(0), id, state.grains_structure, false));
                    }
                    if (state_for_xy_coordinates.Max() == 0 && state.grains_structure[x, y].ID == 0)
                    {
                        current_grains_structure[x, y].ID = 0;
                    }
                    else if (state_for_xy_coordinates.Max() == 0 && state.grains_structure[x, y].ID != 0)
                    {
                        current_grains_structure[x, y].ID = state.grains_structure[x, y].ID;
                    }
                    else
                    {
                        current_grains_structure[x, y].ID = state_for_xy_coordinates.Max();
                    }

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
                        }
                    }
                }
            }
        }
        public void updateState(State state)
        {
            //updateGrainsStructure(state);
            updateGrainsBMP(state);
        }

        public void initState(int number_of_grains)
        {
            for (int y = 0; y < this.dimension; y++)
            {
                for (int x = 0; x < this.dimension; x++)
                {
                    this.grains_structure[y, x] = new Grain(0, 0, Color.CadetBlue);
                }
            }

            this.grains_structure[rand.Next(0, this.dimension - 1), rand.Next(0, this.dimension - 1)] = new Grain(1, 0, Color.DarkRed);

        }

    }
}
