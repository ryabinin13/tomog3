using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomog3
{
    public class Rectangle
    {
        public Rectangle(int x0, int y0, int a, int b, double coefficient)
        {
            X0 = x0;
            Y0 = y0;
            A = a;
            B = b;
            Coefficient = coefficient;
        }
        public int X0 { get; set; }
        public int Y0 { get; set; }
        public int A { get; set; }
        public int B { get; set; }

        public double Coefficient { get; set; }
    }
}
