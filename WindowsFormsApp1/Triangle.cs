using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Triangle
    {
        int a, b;
        public int A { get; set; }
        public int B { get; set; }
        public Triangle(int a, int b)
        {
            //if (a > 0)
             //   this.a = a;
            //else throw new ArgumentOutOfRangeException("negative a");
          //  if (b > 0)
           //     this.b = b;
           // else throw new ArgumentOutOfRangeException("negative b");
           if  (a>0&&b>0)
            {
                this.a = a;
                this.b = b;
            }
            else throw new ArgumentOutOfRangeException("negative a b");
        }
        public double C()
        {
            return Math.Sqrt(a * a + b * b);
        }
        public double S()
        {
            return 0.5 * (a * b);
        }
        public double P()
        {
            return a + b;
        }
    }
}
