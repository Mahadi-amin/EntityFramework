using System;
using System.Collections.Generic;
using System.Text;

namespace AnonymousType
{
    class program
    {
        static void Main(string[] args)
        {
            // Nullable Type Example
            int? x = null;
            if(x == null)
                Console.WriteLine("X is a nullable data type.");
            else
                Console.WriteLine("X = " + x);


            // Anonymous Object
            var anonymous = new { id = 10, name = "Shahadat", address = "Dhaka" };
            Console.WriteLine("Student ID is: " + anonymous.id);
            Console.WriteLine("Student Name is: " + anonymous.name);
            Console.WriteLine("Student address is: " + anonymous.address);


            // Dynamic Keyword
            dynamic dyn = "Hello, Dynamic.";
            Console.WriteLine($"Dynamic Variable: {dyn}");

            dynamic result = Add(4, 5);
            Console.WriteLine($"Result of dynamic method invocation: {result}");
        }   
        static dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }
    }
}