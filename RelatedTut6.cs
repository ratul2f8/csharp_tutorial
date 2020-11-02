using System;
using System.Collections.Generic;
using System.Text;

namespace DerekBanasCSharpTut
{
    //inside of a static class, everything should be eiter static or constant and make
    //everything public to access/use
    public static class ShapeMath
    {
        public static double GetArea(string shape = "", double length1 = 0,
            double length2 = 0)
        {
            if(String.Equals("Rectangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return length1 * length2;
            }else if(String.Equals("Triangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return 0.5 * length2 * length1;
            }
            else if (String.Equals("Circle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return Math.PI * Math.Pow((length1 != 0 ? length1 : length2), 2);
            }
            return -1;
        }
    }
}
