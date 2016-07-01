using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathSolver;

namespace Task3_4
{
    public class Reader
    {
        public List<Matrix> GetMatricesFromFile(string path)
        {
            try
            {
                List<Matrix> matrices = new List<Matrix>();
                List<string> listOfLines = new List<string>(File.ReadAllLines(path));
                double[][] data = new double[listOfLines.Count][];
                int i;
                for (i = 0; i < listOfLines.Count; i++)
                {
                    string[] temp = listOfLines[i].Split(' ');
                    data[i] = new double[temp.Length];
                    int j = 0;
                    foreach (var item in temp)
                    {
                        data[i][j] = double.Parse(item);
                        j++;
                    }
                }
                int index = 0;
                double[,] arr1 = FormArray(data, ref index);
                double[,] arr2 = FormArray(data, ref index);
                matrices.Add(new Matrix(arr1));
                matrices.Add(new Matrix(arr2));
                return matrices;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private double[,] FormArray(double[][] data, ref int index)
        {
            int rows = (int)data[index][0];
            int cols = (int)data[index][1];
            double[,] array = new double[rows, cols];
            index++;
            for (int k = 0; k < rows; k++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[k, j] = data[index][j];
                }
                index++;
            }
            return array;
        }
    }
}
