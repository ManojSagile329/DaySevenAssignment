using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySevenAssignment
{
    
    internal class Calculation
    {
        int res = 0;
        public int a {  get; set; }
        public int b { get; set; }

        public void Choice(int l)
        {
            Calculate(l, ref res);
            Display();
        }

        private void Display()
        {
            
        }

        public void Calculate(int m,ref int r)
        {
            switch(m)
            {
                case 1:
                    Addition(ref r);
                    break;
                case 2:
                    Substraction(ref r);
                    break;
                case 3:
                    Multiplication(ref r);
                    break;
                case 4:
                    Division(ref r);
                    break;
                default:
                    Console.WriteLine("Invalid Choice ");
                    break;
            }

        }

        private void Division(ref int rr)
        {
            rr = a/b;
            Console.WriteLine($"The Division of {a} and {b} is {rr}");
            
        }

        private void Multiplication(ref int rr)
        {
            rr = a*b;
            Console.WriteLine($"The Multiplication of {a} and {b} is {rr}");
        }

        private void Substraction(ref int rr)
        {
            rr = a-b;
            Console.WriteLine($"The Substraction of {a} and {b} is {rr}");
        }

        private void Addition(ref int rr)
        {
            rr = a+b;
            Console.WriteLine($"The Addition of {a} and {b} is {rr}");
        }
    }
}
