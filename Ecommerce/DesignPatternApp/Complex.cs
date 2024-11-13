using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp
{
    public class Complex : ICloneable
    {
        private int real;
        private int imag;
        public Complex(int a, int b)
        {
            real = a;
            imag = b;
        }
        public Complex()
        {

        }

        public object Clone()
        {
            return new Complex{ real = this.real, imag = this.imag };
        }
    }
}
