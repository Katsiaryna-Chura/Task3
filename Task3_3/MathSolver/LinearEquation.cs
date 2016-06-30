using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSolver
{
    public class LinearEquation:Equation
    {
        public double A;
        public double B;

        public LinearEquation() {
            roots = new List<double>();
        }

        public override void SetCoefficients(double[] coefs)
        {
            A = coefs[0];
            B = coefs[1];
        }

        public override int GetNumberOfCoefficients()
        {
            return 2;
        }

        public override string[] GetNamesOfCoefficients()
        {
            return new string[]{"A","B"};
        }

        public override int Solve()
        {
            if(A==0 && B == 0)
            {
                return 1;
            }
            if(A==0 && B != 0)
            {
                return -1;
            }
            this.roots.Add(-B / A);
            return 0;
        }

        public override string ToString()
        {
            if (B < 0)
            {
                return $"Equation: {A}x{B}=0. ";
            }
            return $"Equation: {A}x+{B}=0. ";
        }
    }
}
