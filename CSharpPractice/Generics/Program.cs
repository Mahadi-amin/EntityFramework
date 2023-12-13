using Generics;
using System;
using System.Collections;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GenericsExample
{
    class program
    {
        public static T Swap<T> (ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
            return temp;
        }
        static void Main(string[] args)
        {
            int x = 5, y = 10;
            Console.WriteLine($"Before Swap: x = {x}, y = {y}");

            Swap(ref x, ref y);
            Console.WriteLine($"After Swap: x = {x}, y = {y}");

            Console.WriteLine();

            string s1 = "Hello", s2 = "hello";
            Console.WriteLine($"Before Swap: s1 = {s1}, s2 = {s2}");

            Swap(ref s1, ref s2);
            Console.WriteLine($"After Swap: s1 = {s1}, s2 = {s2}");
        }
    }
}

