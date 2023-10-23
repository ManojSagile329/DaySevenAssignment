using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySevenAssignment
{
    internal class ThreeNumbers
    {
        int res = 0;
        public int a {  get; set; }
        public int b { get; set; }  
        public int c { get; set; }

        public void Display()
        {
            Check(ref res );

            Console.WriteLine($"The Greatest Number among {a},{b} and {c} is {res}");

        }
        public void Check(ref int num)
        {
            if(a>b && a>c)
            {
                num = a;
            }
            else if(b>c && a>b)
            {
                num = b;
            }
            else
            {
                num = c;
            }
        }
    }
}


