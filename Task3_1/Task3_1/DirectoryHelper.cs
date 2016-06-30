using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_1
{
    class DirectoryHelper
    {
        public bool CreateDirInCurrentFolder(string dirName, out string message)
        {
            try
            {
                string currentDir = Directory.GetCurrentDirectory();
                string path = $@"{currentDir}/{dirName}";
                if (Directory.Exists(path))
                {
                    message = "Directory with such name have already existed in the current folder.";
                    return false;
                }
                Directory.CreateDirectory(path);
                message = $"Directory {dirName} was created successfully.";
                return true;
            }
            catch (Exception e)
            {
                message = $"Exception {e.ToString()} ocurred while creating directory.";
                return false;
            }
        }
    }
}

