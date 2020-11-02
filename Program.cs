using System;
namespace DerekBanasCSharpTut
{
    class Program
    {
        static void Sample(string[] args)
        {
            Console.WriteLine("Hello World");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(" Arg {0} : {1}", i, args[i]);
            }
            //another way to get args
            string[] myArgs = Environment.GetCommandLineArgs();
            Console.WriteLine(string.Join(", ", myArgs));
            //calling a function
            SayHello();
            Console.WriteLine("Biggest Integer {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer {0}", int.MinValue);
            Console.WriteLine("Biggest short {0}", short.MaxValue);
            Console.WriteLine("Smallest short {0}", short.MinValue);
            Console.WriteLine("Biggest long {0}", long.MaxValue);
            Console.WriteLine("Smallest long {0}", long.MinValue);
            Console.WriteLine("Biggest byte {0}", byte.MaxValue);
            Console.WriteLine("Smallest byte {0}", byte.MinValue);
            Console.WriteLine("Biggest Decimal {0}", decimal.MaxValue);
            Console.WriteLine("Smallest DEcimal {0}", decimal.MinValue);
            Console.WriteLine("Biggest Double {0}", double.MaxValue);
            Console.WriteLine("Smallest Double {0}", double.MinValue);
            //bool canIVote = true;
            double randomDouble = 1.25464;
            float randomFloat = 1.56467F;
            decimal randomDecimal = 1.5264464364354544654654M;
            decimal randomDecimal2 = 1.4479456423432735873587357435743574354754357M;
            Console.WriteLine("Decimal1 = {0} \n Decimal2 =  {1} \n Resultant = {2}", randomDecimal, randomDecimal2, randomDecimal + randomDecimal2);
            Console.WriteLine(randomDouble);
            Console.WriteLine(randomFloat);
            //printing upto a specific decimal
            double sampleDecimal = 1.5246464F;
            Console.WriteLine("Upto Some : {0}", sampleDecimal.ToString("#.##"));
            //type convertion
            bool b = bool.Parse("true");
            Console.WriteLine(b);
            int integ = int.Parse("5");
            Console.WriteLine(integ);
            float floatf = float.Parse("5.46");
            Console.WriteLine(floatf);

            //Interacting with the data time
            DateTime today = DateTime.Today;
            DateTime pastWeek = today.AddDays(-7); // date you want to add
            DateTime pastMonth = today.AddMonths(-1);
            Console.WriteLine("Date of past week {0}", pastWeek);
            Console.WriteLine("Date of past month {0}", pastMonth);
            DateTime pastYear = today.AddYears(-1);
            Console.WriteLine("Date of past year {0}", pastYear);

            //Timespam : hour, minute, second
            TimeSpan formattedTime = new TimeSpan(8, 30, 00);
            formattedTime = formattedTime.Subtract(new TimeSpan(0, 60, 00)); //60 minutes earlier
            Console.WriteLine("Formatted Time {0}", formattedTime.ToString());

        }
        private static void SayHello()
        {
            string name;
            Console.WriteLine("Whom to say hello ? ");
            name = Console.ReadLine();
            Console.WriteLine("Hello, {0}", name);
        }
    }
}