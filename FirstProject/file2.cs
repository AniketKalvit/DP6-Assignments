using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    // developer2 is working
    public partial class Calc
    {
        public int Square(int a)
        {
            SquareRoot(a);
            return a * a;
        }
        partial void SquareRoot(int a)
        {
            Console.WriteLine("Square root "+Math.Sqrt(a));
        }
    }
}
