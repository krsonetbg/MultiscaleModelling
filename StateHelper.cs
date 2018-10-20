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
    }
}
