using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySevenAssignment
{
     
    internal class GreatestNum
    {
        int res = 0;
        public int a {  get; set; }
        public int b { get; set; }

        public void Check()
        {
            if(a>b)
            {
                res = a;
            }
            else
            {
                res = b;
            }

            Display();

        }

        private void Display()
        {
            Console.WriteLine("The Greatest Number between {0} and {1} is {2}", a, b, res);
        }
    }
}
