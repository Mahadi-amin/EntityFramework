using System;

namespace ParameterModifier
{
    class program
    {
        static void Main(string[] args)
        {
            var example = new Example();
            Console.WriteLine(example.Append("Shahadat", " Hossain ", "Arman"));


            var t = 10;
            example.Test1(ref t);
            Console.WriteLine(t);
        }
    }
}