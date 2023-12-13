using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAdvance
{
    public class PersonalComputer : Computer
    {
        public new void Print(string text)
        {
            Console.WriteLine("Message from PC: " + text);
        }
    }
}
