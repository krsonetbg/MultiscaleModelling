using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Imaging;

namespace MultiscaleModelling
{
    public class FileReader
    {


        //public static State ReadTxtFile(string fileName)
        //{
        //    string path = "..\\..\\InputOutputData\\TxtFiles";
        //    if (!Directory.Exists(path))
        //    {
        //        return null;
        //    }
        //    string pathString = Path.Combine(path, string.Concat(fileName, ".txt"));

        //    String input;
        //    try
        //    {
        //        input = System.IO.File.ReadAllText(pathString);

        //        string[] lines = input.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
        //        int dimension = Convert.ToInt32(lines[0]);
        //        var scope = new State(dimension);

        //        for (int i = 0; i < dimension; i++)
        //        {
        //            string[] grains = lines[i + 2].Split(' ');
        //            for (int j = 0; j < dimension; j++)
        //            {
        //                string[] details = grains[j].Split('=');
        //                scope.grains_structure[i, j] = new Grain()
        //                {
        //                    ID = Convert.ToInt32(details[0]),
        //                    phase = Convert.ToInt32(details[1]),
        //                    color = Color.FromArgb(Convert.ToInt32(details[2]), Convert.ToInt32(details[3]), Convert.ToInt32(details[4]))
        //                };
        //            }
        //        }

        //        //StructureHelpers.UpdateBitmap(scope);
        //        return scope;
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }

        //}

    //    public static State ReadBitmapFile(string fileName)
    //    {
    //        string path = "..\\..\\InputOutputData\\Bitmaps";
    //        if (!Directory.Exists(path))
    //        {
    //            return null;
    //        }
    //        string pathString = Path.Combine(path, string.Concat(fileName, ".bmp"));

    //        var nameParts = fileName.Split('-');

    //        int width = Converters.StringToInt(nameParts[nameParts.Length - 1]);
    //        int height = Converters.StringToInt(nameParts[nameParts.Length - 2]);
    //        var scope = new Scope(width, height);

    //        try
    //        {
    //            scope.StructureBitmap = new Bitmap(pathString);
    //        }
    //        catch (Exception)
    //        {
    //            return null;
    //        }

    //        scope.IsFull = true;
    //        StructureHelpers.UpdateArrayStructure(scope);
    //        return scope;
    //    }
    //}

}
}
