using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public struct Fraction
    { 
        private readonly int num;
        private readonly int den;
        public Fraction(int numerator, int denominator)
        {
            num = numerator;
            den = denominator;
        }    
        public static Fraction operator -(Fraction a)
        {
            return new Fraction (-a.num, a.den);
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.den + b.num * a.den, a.den * b.den);
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return a + (-b);
        }
        public override string ToString()
        {
            return $"""
                  {num} 
                ---------
                  {den}
                """;
        }
    }
}
