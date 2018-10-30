using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;



namespace MultiscaleModelling
{
    public class FileReader
    {


        public static State ReadTxtFile(string fileName)
        {
            String input;
            try
            {
                input = System.IO.File.ReadAllText(fileName);

                string[] lines = input.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                int dimension = Convert.ToInt32(lines[0]);
                var imported_state = new State(dimension);

                for (int i = 2; i < lines.Length; ++i)
                {
                    if (lines[i].All(char.IsWhiteSpace) == false)
                    {

                        string[] split_line = lines[i].Split('\t');
                        
                        var x = Convert.ToInt32(split_line[0]);
                        var y = Convert.ToInt32(split_line[1]);
                        var id = Convert.ToInt32(split_line[2]);
                        var phase = Convert.ToInt32(split_line[3]);
                        //System.Drawing.Color color = System.Drawing.Color.Black;

                        var color_string_array = Regex.Split(split_line[4], "[^\\d]");
                        List<int> color_values = new List<int>();
                        foreach (var s in color_string_array)
                        {
                            if (String.IsNullOrEmpty(s)) continue;
                            color_values.Add(Convert.ToInt32(s));
                        }
                        System.Drawing.Color color = System.Drawing.Color.FromArgb(color_values[0], color_values[1], color_values[2], color_values[3]);

                        imported_state.grains_structure[x, y] = new Grain(id, phase, color);
                    }
                }

                imported_state.updateState(imported_state);
                return imported_state;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public static State ReadBitmapFile(string fileName)
        {

            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(fileName);
            var imported_state = new State(bmp.Width);
            imported_state.grains_bmp = bmp;
            int imported_ID = 0;
            HashSet<System.Drawing.Color> colors = new HashSet<System.Drawing.Color>();
            for (int x = 0; x < imported_state.dimension ; ++x)
            {
                for (int y = 0; y < imported_state.dimension; ++y)
                {
                    System.Drawing.Color pixel_color = bmp.GetPixel(x, y);
                    var c1 = colors.Count;
                    colors.Add(pixel_color);
                    var c2 = colors.Count;
                    if (c2 > c1)
                    {
                        ++imported_ID;
                    }
                    imported_state.grains_structure[x, y] = new Grain(imported_ID, 0, pixel_color);
                }
            }
            return imported_state;
        }
    }

}

