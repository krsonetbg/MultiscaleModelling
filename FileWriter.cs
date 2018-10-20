using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Imaging;

namespace MultiscaleModelling
{
    public static class FileWriter
    {
        public static string SaveGrainStructureTxt(State state_to_save)
        {
            Console.WriteLine("[FileWriter.cs] SaveGrainStructureTxt");
            string directory_path = "..\\..\\InputOutputData\\TxtFiles";
            Directory.CreateDirectory(directory_path);

            string file_name = string.Concat("structure_", DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss"), ".txt");
            string full_path = Path.Combine(directory_path, file_name);

            StringBuilder content = new StringBuilder();

            content.Append(string.Concat(state_to_save.dimension, "\t", state_to_save.dimension, Environment.NewLine));

            string header = "posx\tposy\tID\tPhase\n";
            content.Append(header);

            for (int x = 0; x < state_to_save.dimension; ++x)
            {
                for (int y = 0; y < state_to_save.dimension; ++y)
                {
                    content.Append(Convert.ToString(x)).Append("\t");
                    content.Append(Convert.ToString(y)).Append("\t");
                    content.Append(state_to_save.grains_structure[x, y].ID).Append("\t");
                    content.Append(state_to_save.grains_structure[x, y].phase).Append("\t");
                    content.Append(Environment.NewLine);
                }
            }

            try
            {
                System.IO.File.WriteAllText(full_path, content.ToString());
            }
            catch (IOException e)
            {
                return e.ToString();
            }
            return file_name;
        }

        public static string SaveGrainStructureTxt(State state_to_save, string directory_path)
        {
            Console.WriteLine("[FileWriter.cs] SaveGrainStructureTxt");
            Directory.CreateDirectory(directory_path);

            string file_name = string.Concat("structure_", DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss"), ".txt");
            string full_path = Path.Combine(directory_path, file_name);

            StringBuilder content = new StringBuilder();

            content.Append(string.Concat(state_to_save.dimension, Environment.NewLine));

            string header = "posx\tposy\tID\tPhase\tColor\n";
            content.Append(header);

            for (int x = 0; x < state_to_save.dimension; ++x)
            {
                for (int y = 0; y < state_to_save.dimension; ++y)
                {
                    content.Append(Convert.ToString(x)).Append("\t");
                    content.Append(Convert.ToString(y)).Append("\t");
                    content.Append(state_to_save.grains_structure[x, y].ID).Append("\t");
                    content.Append(state_to_save.grains_structure[x, y].phase).Append("\t");
                    content.Append(state_to_save.grains_structure[x, y].color).Append("\t");
                    content.Append(Environment.NewLine);
                }
            }

            try
            {
                System.IO.File.WriteAllText(full_path, content.ToString());
            }
            catch (IOException e)
            {
                return e.ToString();
            }
            return file_name;
        }

        public static string SaveGrainStructureBMP(State state_to_save)
        {
            Console.WriteLine("[FileWriter.cs] SaveGrainStructureBMP");

            string directory_path = "..\\..\\InputOutputData\\Bitmaps";
            Directory.CreateDirectory(directory_path);

            string file_name = string.Concat("grain_structure_", DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss"), "-", state_to_save.dimension, "-", state_to_save.dimension, ".bmp");
            string full_path = Path.Combine(directory_path, file_name);

            try
            {
                state_to_save.grains_bmp.Save(full_path, ImageFormat.Bmp);
            }
            catch (Exception e)
            {
                return e.ToString();
            }
            return file_name;
        }

        public static string SaveGrainStructureBMP(State state_to_save, string directory_path)
        {
            Console.WriteLine("[FileWriter.cs] SaveGrainStructureBMP");

            Directory.CreateDirectory(directory_path);

            string file_name = string.Concat("grain_structure_", DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss"), "-", state_to_save.dimension, "-", state_to_save.dimension, ".bmp");
            string full_path = Path.Combine(directory_path, file_name);

            try
            {
                state_to_save.grains_bmp.Save(full_path, ImageFormat.Bmp);
            }
            catch (Exception e)
            {
                return e.ToString();
            }
            return file_name;
        }
    }
}
