using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim_lek4_unit_test
{
   public class Triangle
    {
        int a, b;
        public int A { get; set; }
        public int B { get; set; }
        public Triangle (int a, int b)
        {
            if (a>0)
                this.a= a;
            else throw new ArgumentOutOfRangeException("negative a");
            if (b>0)
                this.b= b;
            else throw new ArgumentOutOfRangeException("negative b");
        }
        public double C()
        {
            return Math.Sqrt(a * a + b * b);
        }
        public double S()
        {
            return 0.5*(a * b);
        }
    }
}
