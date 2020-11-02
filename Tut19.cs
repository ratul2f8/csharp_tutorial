using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
//Threads that accept a parameter
namespace DerekBanasCSharpTut
{
    
    class Tut19
    {
        static void CountTo(int maxNum)
        {
            for (int i = 0; i <= maxNum; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void Sample(string[] args)
        {
            Thread t1 = new Thread(() =>
            CountTo(10));
            t1.Start();
            new Thread(() =>
            {
                CountTo(5);
            }).Start();
            new Thread(() =>
            {
                CountTo(100);
            }).Start();
        }
    }
}
