using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySevenAssignment
{
    internal class Students : StudentGrade
    {
        public int[] marks=new int[5];
        /*int id;
        string name;*/
        public Students()
        {
            this.id = id;
            this.name = name;
        }
        public override void EnterMarks()
        {
            Console.WriteLine("Enter The Marks ");
            for(int i=0;i<5;i++)
            {

                Console.WriteLine($"Enter The Marks of subject {i+1} ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            Calculate(marks);
        }
        public override void Calculate(int[] mark)
        {
            foreach(float a in mark)
            {
                total += a;
            }
            aver(total);
        }
        public override void aver(float s)
        {
            average = s / 5;
            if(average>=80 && average<100)
            {
                grade = "First Grade";
            }
            else if(average>60 && average<=79)
            {
                grade = "Second Grade";
            }
            else if(average>30 && average<=59)
            {
                grade = "Third Grade";
            }
            else if(average<30)
            {
                grade = "Fail";
            }
            Display();
        }

        

        public override void Display()
        {
            Console.WriteLine($"ID --------------------------------  {id}");
            Console.WriteLine($"NAME ------------------------------   {name}");
            Console.WriteLine($"Total Marks ----------------------- {total}");
            Console.WriteLine($"Average Marks ---------------------   {average}");
            Console.WriteLine($"Grade -----------------------------   {grade}");
        }

        
    }
}
