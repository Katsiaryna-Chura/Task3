using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathSolver;
using System.IO;
using System.Configuration;

namespace Task3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Reader r = new Reader();
            List<Matrix> matrices = r.GetMatricesFromFile(ConfigurationManager.AppSettings["path"]);
            if(matrices == null)
            {
                Console.WriteLine("Incorrect file.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                return;
            }
            Matrix a = matrices[0];
            Matrix b = matrices[1];
            Matrix c = a.multiply(b);
            Console.WriteLine("Matrix A:");
            Console.WriteLine(a.ToString());
            Console.WriteLine("Matrix B:");
            Console.WriteLine(b.ToString());
            if (c == null)
            {
                Console.WriteLine("Matrix A cannot be multiplied by matrix B. Number of columns in A must be equal to number of rows in B.");
            }
            else
            {
                Console.WriteLine("Matrix C = A*B:");
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }


    }
}
