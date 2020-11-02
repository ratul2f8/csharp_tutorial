using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
//focusing on System Numerics
namespace DerekBanasCSharpTut
{
    class Tut1
    {
        static void Main(string[] args)
        {
            BigInteger bigInt = BigInteger.Parse("1345123451346");
            Console.WriteLine("bigInt*2 = {0}", bigInt * 2);
            //Several formatting options
            Console.WriteLine("Currency : {0:c}", 23.4555);
            Console.WriteLine("Upto 3 decimals : {0:f3}", 1.2356);
            Console.WriteLine("Commas : {0:n4}", 2300);
            //strings
            string randomString = "Hello World";
            string A = "Hello";
            string B = "Hi";
            string C = "hello";
            Console.WriteLine("A == C ? : {0}", String.Equals(A, C, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("A c C ? : {0}", String.Compare(A, C, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("A c B ? : {0}", String.Compare(A, B));

            Console.WriteLine("Length of \'randomString\' : {0}", randomString.Length);
            Console.WriteLine("\'randomString\' contains the word - \'Hello\' ? : {0}", randomString.Contains("Hello"));
            Console.WriteLine("\'randomString\' contains the word - \'Hi\' ? : {0}", randomString.Contains("Hi"));
            Console.WriteLine("Index of the substring :\'rld\' is : {0}", randomString.IndexOf("rld"));

        }
    }
}
