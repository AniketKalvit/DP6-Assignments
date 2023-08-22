using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Calculation
    {
        public void Calculate(int a, int b, out int sum, out int sub, out int mul)
        {
            sum = a + b;
            sub = a - b;
            mul = a * b;
        }

        public void Calculate(int a,out int sq, out double sqroot)
        {
            sq = a * a;
            sqroot = Math.Sqrt(a);
        }
    }
}
