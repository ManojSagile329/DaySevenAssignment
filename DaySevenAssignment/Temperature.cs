using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySevenAssignment
{
    internal class Temperature
    {
        public float temp {  get; set; }

        public void Convert()
        {
            float fh = (temp * 9 / 5f) + 32;
            Display(fh);
        }
        public void Display(float f)
        {
            Console.WriteLine($"The {temp} Celsius is equal to {f} Fahreinheit");
        }
    }
}
