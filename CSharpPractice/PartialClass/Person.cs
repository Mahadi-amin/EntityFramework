using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Person
    {
        public Person() : this(string.Empty) { }
        public void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }
    }
}
