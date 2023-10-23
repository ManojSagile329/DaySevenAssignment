using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySevenAssignment
{
    internal class Bill1
    {
        float total = 0;
        float dis = 0;
        public string prodname {  get; set; }
        public float price {  get; set; }
        public int units {  get; set; }

        public void Calculate()
        {
            total = price * units;
            Discount(ref dis);
            if(dis == 0)
            {
                Display();
            }
            else if(dis > 0)
            {
                Display1();
            }
            
        }

        private void Display1()
        {
            float net = total - dis;
            Console.WriteLine($"Product Name ------------------- {prodname} ");
            Console.WriteLine($"Number of units  ------------------- {units} ");
            Console.WriteLine($"Product Cost ------------------- {price} ");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine($"Total amount ---------------- {total}");
            Console.WriteLine($"Discount ------------------------ {dis}");
            Console.WriteLine($"Final Payment --------------------  {net}");

        }

        private void Discount(ref float d)
        {
            if(total>5000)
            {
                d = total / 10;
            }
            else if(total>2500 && total<5000)
            {
                d = total / 5;
            }
            else if(total<2500)
            {
                d = 0;
            }

        }

        public void Display()
        {
            Console.WriteLine($"Product Name ------------------- {prodname} ");
            Console.WriteLine($"Number of units  ------------------- {units} ");
            Console.WriteLine($"Product Cost ------------------- {price} ");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("No Discount");
            Console.WriteLine($"Total Payable amount ---------------- {total}");
           
        }
    }
}
