using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSolver
{
    public class Matrix
    {
        public int Rows { get; private set; }
        public int Cols { get; private set; }
        public double[,] Values { get; private set; }

        public Matrix(double[,] array)
        {
            this.Rows = array.GetLength(0);
            this.Cols = array.GetLength(1);
            this.Values = array;
        }


        public Matrix multiply(Matrix m)
        {
            if(this.Cols != m.Rows)
            {
                return null;
            }
            double[,] resultMatrix = new double[this.Rows, m.Cols];
            for (int i =0;i<this.Rows;i++)
            {
                for (int j=0;j<m.Cols;j++)
                {
                    resultMatrix[i, j] = 0;
                    for (int r =0;r<this.Cols;r++)
                    {
                        resultMatrix[i, j] += this.Values[i, r] * m.Values[r, j];
                    }
                }
            }
            return new Matrix(resultMatrix);
        }

        public override string ToString()
        {
            string str = "";
            for (int i=0;i<Rows;i++)
            {
                for (int j=0;j<Cols;j++) {
                    str += $"{Values[i,j],5:0.##} ";
                }
                str += "\n";
            }
            return str;
        }
    }
}
