using System;
using System.Collections.Generic;
using System.Text;

namespace Learn
{
    class Complex
    {
        public double _re;
        public double _im;

        public Complex(double im, double re)
        {
            _re = re;
            _im = im;
        }

        public static Complex Substruct(Complex a, Complex b)
        {
            Complex sub = new Complex(0, 0);
            sub._re = a._re - b._re;
            sub._im = a._im - b._im;
            return sub;
        }

        public override string ToString()
        {
            string output;
            if (_im != 0 && _im >= 0 && _im != 1 && _im != -1)
                output = $"{_re} + {_im}i";
            else if (_im != 0 && _im != 1 && _im != -1)
                output = $"{_re} - {-_im}i";
            else if (_im != 0 && _im != 1)
                output = $"{_re} - i";
            else if (_im != 0)
                output = $"{_re} + i";
            else
                output = $"{_re}";
            return output;
        }
    }
}
