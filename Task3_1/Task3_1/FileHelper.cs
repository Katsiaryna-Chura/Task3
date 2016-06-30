using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_1
{
    class FileHelper
    {
        public bool ReadNumberOfLinesFromFile(string path, int number, out string[] lines, out string message)
        {
            lines = null;
            message = null;
            string line;
            if (!File.Exists(path))
            {
                message = $"File to read from ({path}) doesn't exist.";
                return false;
            }
            lines = new string[number];
            using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
            {
                for (int i = 0; i < number; i++)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        lines[i] = line;
                    }
                    else
                    {
                        message = $"The file ({path}) contains only {i} lines. They was read successfully from the file.";
                        return true;
                    }
                }
            }
            message = $"{number} lines was read seccessfully from the file ({path}).";
            return true;
        }

        public bool WriteLinesToFile(string path, string[] lines, out string message)
        {
            try
            {
                File.WriteAllLines(path, lines, Encoding.UTF8);
                message = "Lines was written successfully to the created file.";
                return true;
            }
            catch (Exception e)
            {
                message = $"{e.Message} Cannot create/write to the file.";
                return false;
            }
        }
    }
}

