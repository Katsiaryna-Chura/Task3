using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the directory to create:");
            string dirName = Console.ReadLine();
            string message;
            DirectoryHelper dHelper = new DirectoryHelper();
            if (!dHelper.CreateDirInCurrentFolder(dirName, out message))
            {
                Console.WriteLine(message);
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                return;
            }
            Console.WriteLine(message);
            Console.WriteLine("Enter the name of the file to create in the created directory:");
            string fileName = Console.ReadLine();
            FileHelper fHelper = new FileHelper();
            string[] lines;
            int numberOfLines = Int32.Parse(Data.NumberOfLines);
            if (!fHelper.ReadNumberOfLinesFromFile(Data.Path, numberOfLines, out lines, out message))
            {
                Console.WriteLine(message);
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                return;
            }
            Console.WriteLine(message);
            string newFilePath = $@"{Directory.GetCurrentDirectory()}/{dirName}/{fileName}.txt";
            fHelper.WriteLinesToFile(newFilePath,lines,out message);
            Console.WriteLine(message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}

