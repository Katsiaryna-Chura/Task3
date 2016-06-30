using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_3
{
    class Logger
    {
        string filePath;

        public Logger(string path)
        {
            filePath = path;
        }

        public void Log(string text)
        {
            File.AppendAllText(filePath, text + "\n", Encoding.UTF8);
        }

        public void LogIncorrectInput(string input)
        {
            File.AppendAllText(filePath, $"Incorrect input: {input} instead of a number.\n", Encoding.UTF8);
        }
    }
}
