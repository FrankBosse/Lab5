using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Three different Try-Catch to try and instantiate the Circle object class three times with different radius, if it fails it throws the exception and prints the error
            try
            {
                Circle circle1 = new Circle(10);
                Console.WriteLine(circle1.ToString());
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            try
            {
                Circle circle2 = new Circle(-10);
                Console.WriteLine(circle2.ToString());
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            try
            {
                Circle circle3 = new Circle(0);
                Console.WriteLine(circle3.ToString());
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
