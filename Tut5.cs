//struct only
using System;
using System.Collections.Generic;
using System.Text;

namespace DerekBanasCSharpTut
{
    class Tut5
    {
        struct Rectangle
        {
            public double length;
            public double width;
            
            public Rectangle(double l, double w)
            {
                length = l;
                width = w;
            }
            public double getArea()
            {
                return length * width;
            }
        }
        static void Sample(string[] args)
        {
            //using struct without constructor
            //you have to manually initialize the values
            Rectangle rect1;
            rect1.length = 500;
            rect1.width = 200;
            Console.WriteLine("Area of the Rectangle1 is  : {0}", rect1.getArea());
            //using struct with constructor
            //if values will be passed then fine otherwise will be initialized with the default value 0
            Rectangle rect2 = new Rectangle(400, 300);
            Console.WriteLine("Area of the Rectangle2 is  : {0}", rect2.getArea());
            //assigning one struct instance to another will not create a reference but change the values
            //and further changing of values will not affect the values of parent object
            rect1 = rect2;
            Console.WriteLine("Area of the Rectangle1 is  : {0}", rect1.getArea());
            //try to chnage
            rect1.length = 150;
            Console.WriteLine("Area of the Rectangle1 is  : {0}", rect1.getArea());
            Console.WriteLine("Area of the Rectangle2 is  : {0}", rect2.getArea());


        }
    }
}
