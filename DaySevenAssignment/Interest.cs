using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySevenAssignment
{
    internal class Interest
    {
        float si=0;
        float tt;
        public float amount {  get; set; }
        public int time {  get; set; }
        public float rate {  get; set; }

        public void Calculate()
        {
            si = (amount*rate*time)/100f;
            Display();
        }
        public void Display()
        {
            tt = si + amount;
            Console.WriteLine($"The Principle Amount -----------  {amount}");
            Console.WriteLine($"The rate of interest ------------   {rate}");
            Console.WriteLine($"The Time Period -------------------   {time}");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"The Simple Interest ---------------   {si}");
            Console.WriteLine($"The Total Amount is --------------------  {tt}");
        }

    }
}
