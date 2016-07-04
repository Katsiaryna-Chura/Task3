using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3_2
{
    class Logger
    {
        public string FilePath { get; private set; }

        public Logger(string filePath)
        {
            this.FilePath = filePath;
        }

        public void AddToLog(string text)
        {
            File.AppendAllText(this.FilePath, text);
        }
    }
}
