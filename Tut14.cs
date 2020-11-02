using System;
using System.Collections.Generic;
using System.Text;
//delegate
//you can create a stack of methods having simillar prototype
namespace DerekBanasCSharpTut
{
    class Tut14
    {
        //the delegate itself
        public delegate void Arithmetic(double a, double b);
        //methods that can be stacked or used under this delegate
        public static void Add(double a, double b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, (a + b));
        }
        public static void Sub(double a, double b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, (a - b));
        }
        public static void Sample(string[] args)
        {
            Arithmetic add = new Arithmetic(Add);//the name of the function will be passed as param
            Arithmetic sub = new Arithmetic(Sub);
            Arithmetic addSub = add + sub;
            Arithmetic sub2 = addSub  - sub;
            add(5, 4);
            addSub(10, 4);
            sub2(6, 5);
        }
    }
}
