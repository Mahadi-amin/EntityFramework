using System;
using System.Collections.Generic;

namespace PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mohammadpur");
            person.HelloWorld();
            Console.WriteLine(person.Address);
        }
    }
}