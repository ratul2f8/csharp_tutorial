using System;
using System.Collections.Generic;
using System.Text;

namespace DerekBanasCSharpTut
{
    class Tut3
    {
        static double DoDivision(double x, double y)
        {
            if(y == 0)
            {
                throw new System.DivideByZeroException();
            }
            return x / y;
        }
        static void Sample(string[] args)
        {
            Console.WriteLine("Type Something to start");
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                case 2:
                    Console.WriteLine("Typed 1 or 2");
                    break;
                case 3:
                    Console.WriteLine("Typed 3 ");
                    break;
                default:
                    goto Def;
            }
        Def:
            Console.WriteLine("Hmmm");
            //try catch with a specific error
            double x = 1;
            double y = 0;

            try
            {
                Console.WriteLine("x/y = {0}", DoDivision(x, y));
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.GetType().Name);
            }
            try
            {
                Console.WriteLine("x/y = {0}", DoDivision(x, y));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
