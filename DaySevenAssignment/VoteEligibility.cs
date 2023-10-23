
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySevenAssignment
{
    internal class VoteEligibility
    {
        int age;
        public void Getdata(int data)
        {
            age = data;
            Display(age);

        }

        public void Display(int a)
        {
            if(age > 18)
            {
                Console.WriteLine("You are Eligible for Vote .");
            }
            else
            {
                Console.WriteLine("You are not eligible for vote .Persons with above 18 age is eliible");
            }

        }
    }
}

