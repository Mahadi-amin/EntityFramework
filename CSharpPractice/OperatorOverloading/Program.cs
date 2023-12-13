using System;
using System.Collections.Generic;

namespace OperatorOverloading
{
    class program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(3, 7);
            Fraction fraction2 = new Fraction(2, 9);

            Fraction resutl = fraction1 - fraction2;


            Console.WriteLine(resutl.ToString());
        
        }
    }
}