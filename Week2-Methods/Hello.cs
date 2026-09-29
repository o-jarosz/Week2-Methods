using System;
using System.Collections.Generic;
using System.Text;

namespace Week2_Methods
{
    internal class Hello
    {
        public static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
        public static double CalculateArea(double length, double width)
        {
            double area = length * width;
            return area;
        }
    }
}
