using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
//opeartor overloading
namespace DerekBanasCSharpTut
{
    class Box
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Breadth { get; set; }

        public Box(): this (1, 1, 1) { }
        public Box(double length, double width, double breadth)
        {
            Length = length;
            Width = width;
            Breadth = breadth;
        }
        public static Box operator +(Box box1, Box box2)
        {
            Box newBox = new Box
            {
                Length = box1.Length + box2.Length,
                Breadth = box1.Breadth + box2.Breadth,
                Width = box1.Width + box2.Width
            };
            return newBox;
        }
        public static Box operator -(Box box1, Box box2)
        {
            Box newBox = new Box
            {
                Length = box1.Length - box2.Length,
                Breadth = box1.Breadth - box2.Breadth,
                Width = box1.Width - box2.Width
            };
            return newBox;
        }
        //you have to do matching not equal too.. :/
        public static bool operator ==(Box box1, Box box2)
        {
            if((box1.Length == box2.Length) && (box1.Width == box2.Width) &&
                (box1.Breadth == box2.Breadth))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Box box1, Box box2)
        {
            if ((box1.Length != box2.Length) || (box1.Width != box2.Width) ||
                (box1.Breadth != box2.Breadth))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //convert Box object to a string
        public override string ToString()
        {
            return String.Format("Box with Height {0}, Width {1} and Breadth {2}",
                Length, Width, Breadth);
        }
        //https://stackoverflow.com/questions/1176641/explicit-and-implicit-c-sharp
        //explore this answer to know more about implicit typing
        //if you do implicit you don't have to cast
        //if you do explicit you have to cast
        //here Box object will be converted to an integer
        public static explicit operator int(Box b)
        {
            return (int)(b.Length + b.Width + b.Breadth) / 3;
        }
        //convert integer to a box
        public static implicit operator Box(int i)
        {
            return new Box(i, i, i);
        }
    }
}
