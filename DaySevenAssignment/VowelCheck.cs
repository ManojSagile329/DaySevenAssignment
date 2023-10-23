using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySevenAssignment
{
    internal class VowelCheck
    {
        ArrayList al = new ArrayList() { 'a','e','i','o','u'};
        public char ch {  get; set; }
        public void CheckVowel()
        {
            if(al.Contains(ch))
            {
                Console.WriteLine("{0} is a Vowel ", ch);
            }
            else
            {
                Console.WriteLine("{0} is Not a Vowel ", ch);
            }
        }
    }
}
