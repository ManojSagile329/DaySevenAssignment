using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySevenAssignment
{
    abstract  class StudentGrade
    {
        public int id { get; set; }
        public string name { get; set; }
        //public float[] marks;
        public float total ;
        public float average;

        public string grade = "";

        abstract public void EnterMarks();

        abstract public void Calculate(int[] mark);
        abstract public void aver(float s);

        abstract public void Display();


        


    }
}
