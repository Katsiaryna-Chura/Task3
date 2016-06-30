using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSolver
{
    public abstract class Equation
    {
        protected List<double> roots;
        
        abstract public int Solve();
        abstract public int GetNumberOfCoefficients();
        abstract public string[] GetNamesOfCoefficients();
        abstract public void SetCoefficients(double[] coefs);

        public List<double> GetRoots()
        {
            return roots;
        }
    }
}
