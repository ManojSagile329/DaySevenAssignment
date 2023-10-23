using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySevenAssignment
{
    internal class ShapeChild : Shape
    {
        /*public ShapeChild() 
        {

        }*/

        public override void ChechShape()
        {
           if(length==breadth)
            {
                Console.WriteLine("Its a Sqaure");
            }
           else
            {
                Console.WriteLine("Its a Rectangle");
            }
        }
    }
}
