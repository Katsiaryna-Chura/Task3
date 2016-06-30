using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSolver
{
    public class QuadraticEquation : Equation
    {
        public double A;
        public double B;
        public double C;

        public QuadraticEquation() {
            roots = new List<double>();
        }

        public override void SetCoefficients(double[] coefs)
        {
            A = coefs[0];
            B = coefs[1];
            C = coefs[2];
        }

        public override int GetNumberOfCoefficients()
        {
            return 3;
        }

        public override string[] GetNamesOfCoefficients()
        {
            return new string[] { "A", "B", "C" };
        }

        public override int Solve()
        {           
            if (A == 0)
            {
                LinearEquation eq = new LinearEquation();
                eq.SetCoefficients(new double[]{B,C});
                int result = eq.Solve();
                if(result == 0)
                {
                    roots = eq.GetRoots();
                }
                return result;
            }
            double discriminant = B * B - 4 * A * C;
            if(discriminant < 0)
            {
                return -1;
            }
            if(discriminant == 0)
            {
                
                roots.Add(-B / (2 * A));                
            }
            else
            {
                roots.Add((-B + Math.Sqrt(discriminant)) / (2 * A));
                roots.Add((-B - Math.Sqrt(discriminant)) / (2 * A));
            }
            return 0;
        }

        public override string ToString()
        {
            if(B < 0 && C < 0)
            {
                return $"Equation: {A}x2{B}x{C}=0. ";
            }
            if (B<0 && C>0)
            {
                return $"Equation: {A}x2{B}x+{C}=0. ";
            }
            if (B>0 && C<0)
            {
                return $"Equation: {A}x2+{B}x{C}=0. ";
            }
            return $"Equation: {A}x2+{B}x+{C}=0. ";
        }
    }
}
