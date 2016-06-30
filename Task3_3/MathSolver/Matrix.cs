using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSolver
{
    public class Matrix
    {
        public int Rows { get; }
        public int Cols { get; }
        public double[,] Values { get; }

        public Matrix(double[,] array)
        {
            Rows = array.GetLength(0);
            Cols = array.GetLength(1);
            Values = array;
        }

        public void SetValue(int i,int j, double value)
        {
            Values[i, j] = value;
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
                    str += $"{Values[i,j]:0.##} ";
                }
                str += "\n";
            }
            return str;
        }
    }
}
