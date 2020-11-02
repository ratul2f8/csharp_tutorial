using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DerekBanasCSharpTut
{
    class Tut4
    {
        enum CarColors: byte
        {
            Orange = 1,
            Yellow,
            Blue
        }
        static void SquareIt(double x, out double y)
        {
            y = Math.Pow(x, 2);
        }
        static void swapReferences(ref double x, ref double y)
        {
            double temp = x;
            x = y;
            y = temp;
            Console.WriteLine("From Method : \n x: {0}, y : {1}", x, y);
        }
        static double getSum(params double[] numbers)
        {
            double sum = 0;
            foreach(double element in numbers)
            {
                sum += element;
            }
            return sum;
        }
        static double getSum(params string[] numbers)
        {
            double sum = 0;
            foreach (string element in numbers)
            {
                sum += Convert.ToDouble(element);
            }
            return sum;
        }
        static void swapValues( double x = 5, double y = 7)
        {
            double temp = x;
            x = y;
            y = temp;
            Console.WriteLine("From Method : \n x: {0}, y : {1}", x, y);
        } 
        static void PrintInfo(string name, string city)
        {
            Console.WriteLine("{0} lives in {1}.", name, city);
        }
        static void Sample(string[] args)
        {
            //pass by value
            double x = 1, y = 2;
            swapValues(x, y);
            Console.WriteLine("From main \n x : {0}, y : {1}", x, y);
            //using the out parameter
            double squared;
            SquareIt(15, out squared);
            Console.WriteLine("{0}^2 = {1}", 15, squared);
            //pass by reference
            swapReferences(ref x, ref y);
            Console.WriteLine("From main \n x : {0}, y : {1}", x, y);
            //params
            Console.WriteLine("Sum of: 1,2,3,4,5 is : {0}", getSum(1, 2, 3, 4, 5));
            //different way of passing parameters in functions
            //without maintaining the hierarchy
            PrintInfo(city: "Wales", name: "Bruno");
            //method overloading
            Console.WriteLine("Sum of: 1,2,3 is : {0}", getSum("1", "2", "3"));
            //enum
            CarColors cc = CarColors.Yellow;
            Console.WriteLine("The car was painted in {0} with the color code of {1}", cc, (int)cc);
        }
    }
}
