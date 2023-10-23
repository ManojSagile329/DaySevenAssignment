using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySevenAssignment
{
    abstract internal class Shape
    {
        public int length { get; set; }
        public int breadth { get; set; }

        abstract public  void ChechShape();
    }
}
