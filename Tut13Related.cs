using System;
using System.Collections.Generic;
using System.Text;

namespace DerekBanasCSharpTut
{
    class Animal13
    {
        public string Name { get; set; }
        public Animal13(string name = "No Name")
        {
            Name = name;
        }
        //generic method
        //with pass by reference
        public static void GetSumRef<T>(ref T a, ref T b)
        {
            double doubleX = Convert.ToDouble(a);
            double doubleY = Convert.ToDouble(b);
            Console.WriteLine($"{doubleX} + {doubleY} = {doubleX + doubleY}");
        }
        //with pass by value
        public static void GetSum<T>(T a, T b)
        {
            double doubleX = Convert.ToDouble(a);
            double doubleY = Convert.ToDouble(b);
            Console.WriteLine($"{doubleX} + {doubleY} = {doubleX + doubleY}");
        }
    }
}
