using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatureApp
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }
        public Complex() {
            Real = 0;
            Imag = 0;
        }
        public Complex(int x, int y)
        {
            Real = x;
            Imag = y;
        }

        public static Complex operator +(Complex x, Complex y)
        {
            return new Complex { Real = x.Real + y.Real, Imag = x.Imag + y.Imag};
        }

        public override string ToString()
        {
            return Real + " i" + Imag;
        }
    }
}
