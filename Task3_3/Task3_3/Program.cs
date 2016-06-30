using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathSolver;
using System.Globalization;

namespace Task3_3
{
    class Program
    {
        public static Logger logger;

        static void Main(string[] args)
        {
            logger = new Logger(Data.LogFilePath);
            string answer;
            do {
                Equation eq = null;
                ChooseTypeOfEquation(ref eq);
                EnterCoefficients(eq);
                int result = eq.Solve();
                WriteResults(eq, result, eq.GetRoots());
                Console.WriteLine("Do you want to solve one more equation?('no' - exit program, any other key - continue)");
                answer = Console.ReadLine();
            } while (!answer.Equals("no"));
        }

        public static void ChooseTypeOfEquation(ref Equation eq)
        {
            string choice;
            do
            {
                Console.WriteLine("Choose the type of equation:\n1 - Linear\n2 - Quadratic");
                choice = Console.ReadLine();
            } while ((!choice.Equals("1")) && (!choice.Equals("2")));
            switch (choice)
            {
                case "1":
                    eq = new LinearEquation();
                    break;
                case "2":
                    eq = new QuadraticEquation();
                    break;
            }
        }

        public static void EnterCoefficients(Equation eq)
        {
            double[] coefs = new double[eq.GetNumberOfCoefficients()];
            bool isNumber;
            string input;
            NumberFormatInfo nfi = CultureInfo.CurrentCulture.NumberFormat;
            for (int i = 0; i<eq.GetNumberOfCoefficients();i++)
            {
                do
                {
                    Console.WriteLine($"Enter cofficient {eq.GetNamesOfCoefficients()[i]}:");
                    input = Console.ReadLine();
                    isNumber = Double.TryParse(input.Replace(',', '.').Replace('.', nfi.NumberDecimalSeparator[0]), out coefs[i]);
                    if (!isNumber)
                    {
                        Console.WriteLine("You must enter a number!");
                        logger.LogIncorrectInput(input);
                    }
                } while (!isNumber);
            }
            eq.SetCoefficients(coefs);
            
        }

        public static void WriteResults(Equation eq,int result, List<double> roots)
        {
            string message = eq.ToString();
            switch (result)
            {
                case -1:
                    message += "The equation doesn't have any root.";
                    break;
                case 0:
                    message += "Roots of the equation: ";
                    foreach(var root in roots)
                    {
                        if (Math.Abs(root % 1) < Double.Epsilon)
                        {
                            message += $" x = {root}; ";
                        }
                        else
                        {
                            message += $" x = {root:0.00}; ";
                        }
                    }
                    break;
                case 1:
                    message += "The equation has an infinite number of roots.";
                    break;
            }
            Console.WriteLine(message);
            logger.Log(message);
        }
    }
}
