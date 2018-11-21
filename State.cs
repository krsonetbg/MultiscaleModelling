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


        public State() { }
        public State(int dim)
        {
            grains_structure = new Grain[dim, dim];
            grains_bmp = new Bitmap(dim, dim);
            dimension = dim;
        }

        public Grain[,] updateGrainsStructure(State state, string neighborhood_type = "VonNeumann")
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
                            {
                                var n = getNumberOfNeighbors(x, y, state.grains_structure.GetLength(0), item.Key, state.grains_structure, neighborhood_type);
                                state_for_xy_coordinates.Add(n);
                            }

                        }

                        if (state_for_xy_coordinates.Max() == 0 && state.grains_structure[x, y].ID == 0)
                        {
                            current_grains_structure[x, y] = new Grain(0, 0, grain_ID_Color_dict[0]);
                        }

                        else
                        {
                            int grain_id = state_for_xy_coordinates.IndexOf(state_for_xy_coordinates.Max()) + 1; // +1, because first ID to be considered is 1, but first element added to list has index 0 

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
                Color c = Color.FromArgb(255, rand.Next(10, 256), rand.Next(10, 256), rand.Next(10, 256));
                var x = rand.Next(0, this.dimension - 1);
                var y = rand.Next(0, this.dimension - 1);
                while (this.grains_structure[x, y].ID != 0)
                {
                    x = rand.Next(0, this.dimension - 1);
                    y = rand.Next(0, this.dimension - 1);
                };

                this.grains_structure[x, y] = new Grain(i, 0, c);
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

        public void addInclusion(Tuple<int, int> inclusion_center, int inclusion_size, char inclusion_type = 'c')
        {
            if (inclusion_type == 'c')
            {
                int radius = inclusion_size;
                var circle = StateHelper.getIndicesWithinRadius(radius, inclusion_center, this.dimension);
                for (int i = 0; i < circle.Count; ++i)
                {
                    circle[i] = StateHelper.validateAndAdjustPointCoordinates(circle[i], this.dimension);
                    this.grains_structure[circle[i].Item1, circle[i].Item2] = new Grain(-1, 0, Color.Black);
                }
            }
            else
            {
                int side = inclusion_size;
                var square = StateHelper.getIndicesInsideSquare(side, inclusion_center, this.dimension);
                for (int i = 0; i < square.Count; ++i)
                {
                    square[i] = StateHelper.validateAndAdjustPointCoordinates(square[i], this.dimension);
                    this.grains_structure[square[i].Item1, square[i].Item2] = new Grain(-1, 0, Color.Black);
                }
            }

        }

        public void addGrainsToExistingStructure(int number_of_grains_to_add)
        {

            for (int i = 1; i <= number_of_grains_to_add; ++i)
            {
                Color c = Color.FromArgb(255, rand.Next(10, 256), rand.Next(10, 256), rand.Next(10, 256));
                var x = rand.Next(0, this.dimension - 1);
                var y = rand.Next(0, this.dimension - 1);
                while (this.grains_structure[x, y].ID != 0)
                {
                    x = rand.Next(0, this.dimension - 1);
                    y = rand.Next(0, this.dimension - 1);
                };

                var max_grain_id = getGrainIDs().Max();
                int new_grain_id = ++max_grain_id;
                this.grains_structure[x, y] = new Grain(new_grain_id, 0, c);
                grain_ID_Color_dict.Add(new_grain_id, c);
            }

        }

        public bool isStructureFull()
        {

            for (int x = 0; x < this.dimension; ++x)
            {
                for (int y = 0; y < dimension; ++y)
                {
                    if (grains_structure[x, y].ID == 0) return false;
                }
            }

            return true;
        }

        public void generateStructure(int number_of_grains, char structure_type)
        {

            HashSet<int> grain_IDs_to_preserve = new HashSet<int>();
            while (grain_IDs_to_preserve.Count < number_of_grains)
            {
                grain_IDs_to_preserve.Add(rand.Next(1, getNumberOfIDs() + 1)); // Draw  random IDs of grains to preserve, ensure that they are not repeated
            }

            List<List<Tuple<int, int, Grain>>> grains_to_preserve = new List<List<Tuple<int, int, Grain>>>();

            foreach (var id in grain_IDs_to_preserve)
            {
                grains_to_preserve.Add(getGrainByID(id));
            }
            initState(0); // Clear grain structure
            if (structure_type == 's')
            {
                addPreservedGrainsAndPrepareSpace(grains_to_preserve);               
            }
            else
            {
                bool dual_phase = true;
                addPreservedGrainsAndPrepareSpace(grains_to_preserve, dual_phase);
            }
        }

        public void addPreservedGrainsAndPrepareSpace(List<List<Tuple<int, int, Grain>>> preserved_grains, bool is_dual_phase = false)
        {
            for (var j = 0; j < preserved_grains.Count(); ++j)
            {

                for (var k = 0; k < preserved_grains.ElementAt(j).Count(); ++k)
                {
                    int x = preserved_grains.ElementAt(j).ElementAt(k).Item1;
                    int y = preserved_grains.ElementAt(j).ElementAt(k).Item2;
                    Grain grain = preserved_grains.ElementAt(j).ElementAt(k).Item3;
                    if (is_dual_phase)
                    {
                        grain.phase += 1;
                        grain.color = Color.Crimson;
                    }
                    else
                    {
                        //grain.color = Color.DeepSkyBlue;
                        grain.color = preserved_grains.ElementAt(j).ElementAt(k).Item3.color;
                    }
                    Color c = grain.color;

                    int new_grain_id = grain.ID * (-2);
                    if (!grain_ID_Color_dict.TryGetValue(new_grain_id, out c))
                    {
                        //int new_grain_id = grain.ID * (-2);
                        grain_ID_Color_dict.Add(new_grain_id, grain.color);
                    }
                    grains_structure[x, y] = grain;
                }
            }
        }

        public List<Tuple<int, int, Grain>> getGrainByID(int ID)
        {
            List<Tuple<int, int, Grain>> grain = new List<Tuple<int, int, Grain>>();
            for (var x = 0; x < dimension; ++x)
            {
                for (var y = 0; y < dimension; ++y)
                {
                    if (grains_structure[x, y].ID == ID)
                    {
                        Tuple<int, int, Grain> g = new Tuple<int, int, Grain>(x, y, grains_structure[x, y]);
                        grain.Add(g);
                    }
                }
            }
            return grain;
        }

        public int getNumberOfIDs()
        {
            HashSet<int> IDs = new HashSet<int>();
            for (var x = 0; x < dimension; ++x)
            {
                for (var y = 0; y < dimension; ++y)
                {
                    IDs.Add(grains_structure[x, y].ID);
                }
            }
            return IDs.Count;
        }

        public HashSet<int> getGrainIDs()
        {
            HashSet<int> IDs = new HashSet<int>();
            for (var x = 0; x < dimension; ++x)
            {
                for (var y = 0; y < dimension; ++y)
                {
                    IDs.Add(grains_structure[x, y].ID);
                }
            }
            return IDs;
        }

        public bool extendedCARule1(Tuple<int, int> cell_coordinates)
        {
            var x = cell_coordinates.Item1;
            var y = cell_coordinates.Item2;

            if (grains_structure[x, y].ID == 0) // Cell is empty, no viable grain is there
            {
                Dictionary<int,int> neighbors_numerical_amount = new Dictionary<int, int>();

                foreach (var item in grain_ID_Color_dict)
                {
                    //if (item.Key != 0 && item.Key != -1) // Count only non-zero neighbors, do not count inclusions
                    if (isIDValidForCheckingNeighborhood(item.Key))
                        neighbors_numerical_amount.Add(item.Key,getNumberOfNeighbors(x, y, grains_structure.GetLength(0), item.Key, grains_structure, "MooreClassic"));
                }

                int max_neighbors_number = neighbors_numerical_amount.Values.Max();
                if (max_neighbors_number >= 5)
                {
                    int grain_id = neighbors_numerical_amount.Aggregate((p, r) => p.Value > r.Value ? p : r).Key;
                    grains_structure[x, y] = new Grain(grain_id, 0, grain_ID_Color_dict[grain_id]);
                    return true;
                }
            }
            return false; // Check extendedCARule2
        }
        public bool extendedCARule2(Tuple<int, int> cell_coordinates)
        {
            var x = cell_coordinates.Item1;
            var y = cell_coordinates.Item2;

            if (grains_structure[x, y].ID == 0) // Cell is empty, no viable grain is there
            {
                Dictionary<int, int> neighbors_numerical_amount = new Dictionary<int, int>();

                foreach (var item in grain_ID_Color_dict)
                {
                    //if (item.Key != 0 && item.Key != -1) // Count only non-zero neighbors, do not count inclusions
                    if (isIDValidForCheckingNeighborhood(item.Key))
                        neighbors_numerical_amount.Add(item.Key,getNumberOfNeighbors(x, y, grains_structure.GetLength(0), item.Key, grains_structure, "VonNeumann"));

                }

                int max_neighbors_number = neighbors_numerical_amount.Values.Max();
                if (max_neighbors_number == 3)
                {
                    int grain_id = neighbors_numerical_amount.Aggregate((p, r) => p.Value > r.Value ? p : r).Key;
                    grains_structure[x, y] = new Grain(grain_id, 0, grain_ID_Color_dict[grain_id]);
                    return true;
                }
            }

            return false; // Check extendedCARule3

        }
        public bool extendedCARule3(Tuple<int, int> cell_coordinates)
        {
            var x = cell_coordinates.Item1;
            var y = cell_coordinates.Item2;

            if (grains_structure[x, y].ID == 0) // Cell is empty, no viable grain is there
            {
                Dictionary<int, int> neighbors_numerical_amount = new Dictionary<int, int>();

                foreach (var item in grain_ID_Color_dict)
                {
                    //if (item.Key != 0 && item.Key != -1) // Count only non-zero neighbors, do not count inclusions
                    if (isIDValidForCheckingNeighborhood(item.Key))
                        neighbors_numerical_amount.Add(item.Key, getNumberOfNeighbors(x, y, grains_structure.GetLength(0), item.Key, grains_structure, "MooreFurther"));

                }

                int max_neighbors_number = neighbors_numerical_amount.Values.Max();

                if (max_neighbors_number == 3)
                {
                    int grain_id = neighbors_numerical_amount.Aggregate((p, r) => p.Value > r.Value ? p : r).Key;
                    grains_structure[x, y] = new Grain(grain_id, 0, grain_ID_Color_dict[grain_id]);
                    return true;
                }
            }

            return false; // Check extendedCARule4

        }
        public bool extendedCARule4(Tuple<int, int> cell_coordinates, int probaility)
        {
            var x = cell_coordinates.Item1;
            var y = cell_coordinates.Item2;

            if (grains_structure[x, y].ID == 0) // Cell is empty, no viable grain is there
            {
                Dictionary<int, int> neighbors_numerical_amount = new Dictionary<int, int>();

                foreach (var item in grain_ID_Color_dict)
                {
                    //if (item.Key != 0 && item.Key != -1) // Count only non-zero neighbors, do not count inclusions
                    if (isIDValidForCheckingNeighborhood(item.Key))
                        neighbors_numerical_amount.Add(item.Key, getNumberOfNeighbors(x, y, grains_structure.GetLength(0), item.Key, grains_structure, "MooreClassic"));
                }
                var random_number = rand.Next(1, 101);

                int max_neighbors_number = neighbors_numerical_amount.Values.Max();

                if (random_number < probaility && max_neighbors_number > 0)
                {
                    int grain_id = neighbors_numerical_amount.Aggregate((p, r) => p.Value > r.Value ? p : r).Key;
                    grains_structure[x, y] = new Grain(grain_id, 0, grain_ID_Color_dict[grain_id]);
                    return true;
                }
            }

            return false;
        }

        public Grain[,] updateGrainsStructureExtendedCA(State state, int probability = 10)
        {
            Grain[,] current_grains_structure = new Grain[state.dimension, state.dimension];

            for (var x = 0; x < dimension; ++x)
            {
                for (var y = 0; y < dimension; ++y)
                {
                    var coordinates = new Tuple<int, int>(x, y);
                    if (extendedCARule1(coordinates)) continue;
                    if (extendedCARule2(coordinates)) continue;
                    if (extendedCARule3(coordinates)) continue;
                    if (extendedCARule4(coordinates, probability)) continue;
                }
            }

            current_grains_structure = state.grains_structure;
            return current_grains_structure;
        }

        private int getNumberOfNeighborsMooreFurther(int x, int y, int id, int dim, Grain[,] space)
        {
            int neighbors = 0;
                // Count neighbors on diaganals
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
            return neighbors;
        }

        private int getNumberOfNeighborsVonNeumann(int x, int y, int id, int dim, Grain[,] space)
        {
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

            return neighbors;
        }

        private int getNumberOfNeighborsMooreClassic(int x, int y, int id, int dim, Grain[,] space)
        {
            var neighbors =  getNumberOfNeighborsVonNeumann(x, y, id, dim, space) + getNumberOfNeighborsMooreFurther(x, y, id, dim, space);
            return neighbors;
        }

        private int getNumberOfNeighbors(int x, int y, int dim, int id, Grain[,] space, string neighborhood_type)
        {
            int number_of_neighbors = 0;
            switch (neighborhood_type)
            {
                case "MooreClassic": number_of_neighbors += getNumberOfNeighborsMooreClassic(x, y, id, dim, space); break;
                case "VonNeumann": number_of_neighbors += getNumberOfNeighborsVonNeumann(x, y, id, dim, space); break;
                case "MooreFurther": number_of_neighbors += getNumberOfNeighborsMooreFurther(x, y, id, dim, space); break;
                default: return -1;
            }

            return number_of_neighbors;
        }

        private bool isIDValidForCheckingNeighborhood(int ID)
        {
            return ID > 0; // Because: 0 - is empty space, does not count, -1 - is inclusion, does not count, negative numbers - are either substructures or another phase 
        }

        // MONTE CARLO METHOD
        private HashSet<int> mc_getNeighborsIDs(int x, int y, int dim, Grain[,] space)
        {
            // TODO
            // check if coordinates in all conditions are valid...
            HashSet<int> neigbors_IDs = new HashSet<int>();
            int self_ID = space[x, y].ID;
            // Moore furthest
            if (x + 1 < dim && y + 1 < dim)
            {
                int checked_ID = space[x + 1, y + 1].ID;   
                if (!neigbors_IDs.Contains(checked_ID) && checked_ID != self_ID)
                {
                    neigbors_IDs.Add(checked_ID);
                }
            }
            if (x + 1 < dim && y - 1 >= 0 )
            {
                int checked_ID = space[x + 1, y - 1].ID;
                if (!neigbors_IDs.Contains(checked_ID) && checked_ID != self_ID)
                {
                    neigbors_IDs.Add(checked_ID);
                }
            }
            if (x - 1 >= 0 && y + 1 < dim )
            {
                int checked_ID = space[x - 1, y + 1].ID;
                if (!neigbors_IDs.Contains(checked_ID) && checked_ID != self_ID)
                {
                    neigbors_IDs.Add(checked_ID);
                }
            }
            if (x - 1 >= 0 && y - 1 >= 0 )
            {
                int checked_ID = space[x - 1, y - 1].ID;
                if (!neigbors_IDs.Contains(checked_ID) && checked_ID != self_ID)
                {
                    neigbors_IDs.Add(checked_ID);
                }
            }
            // Von Neumann
            if (x + 1 < dim )
            {
                int checked_ID = space[x + 1, y ].ID;
                if (!neigbors_IDs.Contains(checked_ID) && checked_ID != self_ID)
                {
                    neigbors_IDs.Add(checked_ID);
                }
            }
            if (x - 1 >= 0 )
            {
                int checked_ID = space[x - 1, y ].ID;
                if (!neigbors_IDs.Contains(checked_ID) && checked_ID != self_ID)
                {
                    neigbors_IDs.Add(checked_ID);
                }
            }
            if (y + 1 < dim )
            {
                int checked_ID = space[x , y + 1].ID;
                if (!neigbors_IDs.Contains(checked_ID) && checked_ID != self_ID)
                {
                    neigbors_IDs.Add(checked_ID);
                }
            }
            if (y - 1 >= 0 )
            {
                int checked_ID = space[x , y - 1].ID;

                if (!neigbors_IDs.Contains(checked_ID) && checked_ID != self_ID)
                {
                    neigbors_IDs.Add(checked_ID);
                }
            }
            return neigbors_IDs;
        }

        private double mc_getCellEnergy(int x, int y, Grain[,] space, double Jgb = 1.0)
        {
            int dim = space.GetLength(0);
            int number_of_neighbors_with_different_ID = mc_getNeighborsIDs(x, y, dim, space).Count;
            double energy = Jgb * number_of_neighbors_with_different_ID;
            return energy;
        }

        private void mc_changeID(int x, int y, int dim, Grain[,] space)
        {
            HashSet<int> possible_IDs = mc_getNeighborsIDs(x, y, dim, space);
            int new_ID = possible_IDs.ElementAt(rand.Next(possible_IDs.Count));
            space[x, y].ID = new_ID;
        }

        private double calculateEnergyDifference()
        {
            return 0.0;
        }
    }
}
