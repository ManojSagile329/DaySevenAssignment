using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySevenAssignment
{
    internal class EvenOrOdd
    {
       
        
        public int num {  get; set; }

        public void CheckNum()
        {
            if(num%2==0)
            {
                Console.WriteLine("{0} Its a Even Number ",num);
            }
            else
            {
                Console.WriteLine("{0} Its a Odd Number ", num);
            }
        }

    }
}
