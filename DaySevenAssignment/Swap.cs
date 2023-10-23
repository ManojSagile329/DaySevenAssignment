using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySevenAssignment
{
    internal class Swap
    {
        
        public int a {  get; set; }
        public int b { get; set; }
        public void Display1()
        {
            Console.WriteLine("The Values of a before swap is {0}", a);
            Console.WriteLine("The Values of b before swap is {0}", b);
            Swapping( a, b);
        }
        public void Swapping(int a , int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;

            Display2( a, b);
        }
        public void Display2(int a, int b)
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("The Values of a before swap is {0}", a);
            Console.WriteLine("The Values of b before swap is {0}", b);
        }

    }
}
