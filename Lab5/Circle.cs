using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    //Our Circle class
    internal class Circle
    {
        //Field
        private double radius;

        //Property
        public double Radius
        {
            get {  return radius; }
            set
            {
                SetRadius(value);
            }
        }

        //Constructor
        public Circle(double radius)
        {
            Radius = radius;
        }

        //SetRadius method needed for lab, checks for rad<0 if so throws exception
        public void SetRadius(double rad)
        {
            if (rad < 0)
            {
                Console.WriteLine("*************************************");
                throw new InvalidRadiusException("Radius can't be negative or infinity");
            }

            this.radius = rad;
        }

        //Calculates area to display later
        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        //Overriden ToString to display area of what radius
        public override string ToString()
        {
            return $"*************************************\n" +
                $"Area for rad={Radius} is: {Area()}";
        }
    }
}
