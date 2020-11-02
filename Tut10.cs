using System;
using System.Collections.Generic;
using System.Text;
//Abstract class, abstract Methods, Base Classes, Is, As , Casting and Polymorphism going on
namespace DerekBanasCSharpTut
{
    //implementing abstract class
    class Rectangele10: Shape10
    {
        public double Length { get; set; }
        public double Height { get; set; }
        public Rectangele10(double length, double height)
        {
            Name = "Rectangle";
            Length = length;
            Height = height;

        }
        public override double Area()
        {
            return Length * Height;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Area of the {0} is {1: 0.00}", Name, this.Area());
        }

    }
    class Circle10: Shape10
    {
        public double Radius { get; set; }
        public Circle10(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }
        //you can;t change the prototype of a function
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        //calling the method of base class
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Area of the Circle is {0: 0.00}", this.Area());
        }
    }
    class Tut10
    {
        public static void Sample(string[] args)
        {
            Shape10[] shapes = { new Circle10(5), new Rectangele10(12, 5) };
            foreach(Shape10 shape in shapes)
            {
                shape.GetInfo();
            }
            //object casting
            object circle1 = new Circle10(4);
            Circle10 circle2 = (Circle10)circle1;
            circle2.GetInfo();
            Console.WriteLine(circle2 as Shape10);
            Console.WriteLine(circle2 is Circle10);
        }
    }
}
