using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiscaleModelling
{
    class StateHelper
    {
        public static Tuple<int,int> validateAndAdjustPointCoordinates(Tuple<int,int> point_to_validate, int space_dimension)
        {
            Console.WriteLine("[StateHelper.cs] ");
            int validated_x = point_to_validate.Item1;
            int validated_y = point_to_validate.Item2;
            if (point_to_validate.Item1 >= space_dimension) validated_x = space_dimension - 1;
            if (point_to_validate.Item2 >= space_dimension) validated_y = space_dimension - 1;
            if (point_to_validate.Item1 < 0) validated_x = space_dimension - 1;
            if (point_to_validate.Item2 < 0) validated_y = space_dimension - 1;

            Tuple<int, int> validated_point = new Tuple<int, int>(validated_x,validated_y);
            return validated_point;
        }
        public static List<Tuple<int,int>> getIndicesWithinRadius(int radius, Tuple<int, int> center, int dimension)
        {
            List<Tuple<int, int>> indices_coordinates = new List<Tuple<int, int>>();
            for (int i = 0; i< dimension; ++i)
            {
                for (int j = 0; j< dimension; ++j)
                {
                    int dx = center.Item1 - i;
                    int dy = center.Item2 - j;
                    dx *= dx;
                    dy *= dy;
                    double distance = Math.Sqrt(dx+dy);
                    if (distance <= Convert.ToDouble(radius))
                    {
                        Tuple<int, int> point = new Tuple<int, int>(i, j);
                        indices_coordinates.Add(point);
                    }
                }
            }
            return indices_coordinates;
        }
        public static List<Tuple<int, int>> getIndicesInsideSquare(int side, Tuple<int, int> center, int dimension)
        {
            List<Tuple<int, int>> indices_coordinates = new List<Tuple<int, int>>();
            for (int i = 0; i < dimension; ++i)
            {
                for (int j = 0; j < dimension; ++j)
                {
                    var top = center.Item2 - side /2.0;
                    var bottom = center.Item2 + side /2.0;
                    var left = center.Item1 - side / 2.0;
                    var right = center.Item1 + side / 2.0;

                    if (left < 0) left = 0;
                    if (right >= dimension) right = dimension - 1;
                    if (top < 0) top = 0;
                    if (bottom >= dimension) bottom = dimension - 1;

                    if(i>left && i<right && j>top && j<bottom)
                    {
                        Tuple<int, int> point = new Tuple<int, int>(i, j);
                        indices_coordinates.Add(point);
                    }
                }
            }
            return indices_coordinates;
        }
    }
}
