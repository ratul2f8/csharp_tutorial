using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
//LINQ
namespace DerekBanasCSharpTut
{
    class IProcessExample
    {
        public string ProcessName { get; set; } = "No Process";
        public double BurstTime { get; set; } = 0;
        public double ArrivalTime { get; set; } = 0;
    }
    class Tut15
    {
        //lambda expression: simillar to js array, but declaring the prototype
        //as a delegate is quite handy
        public delegate void DoubleIt(double d);
        public delegate double QubeIt(double q);
        public static void Sample(string[] args)
        {
            //lambda function
            //single line : same as JavaScript
            DoubleIt dblIt = x => Console.WriteLine($"Double of {x} is : {x * 2}");
            //multipleLine Approach
            QubeIt qbIt = q => {
                var p = 3;
                return Math.Pow(q, p);
            };
            dblIt(5);
            Console.WriteLine("Qube of {0} is {1}", 6, qbIt(6));
            //use lambda as a callback like js
            List<int> intArrrays = new List<int> { 4, 6, 9, 1, 5 };
            var greaterThanFours = intArrrays.Where(x => x > 4);
            foreach(object obj in greaterThanFours)
            {
                Console.WriteLine($"Greate than 4 : {obj}");
            }
            //sort using lambda like js
            intArrrays.Sort((x,y) => x>y ? 1 : -1);
            Console.WriteLine("After Sort..");
            Console.WriteLine(string.Join(",", intArrrays));
            //sort list of objects using lambda
            List<IProcessExample> processList = new List<IProcessExample>();
            processList.Add(new IProcessExample()
            {
                ProcessName = "Process1", ArrivalTime = 2, BurstTime = 5
            });
            processList.Add(new IProcessExample()
            {
                ProcessName = "Process2",
                ArrivalTime = 2,
                BurstTime = 5
            });
            processList.Add(new IProcessExample()
            {
                ProcessName = "Process3",
                ArrivalTime = 1,
                BurstTime = 5
            });
            processList.Add(new IProcessExample()
            {
                ProcessName = "Process4",
                ArrivalTime = 3,
                BurstTime = 9
            });
            processList.Sort((p1, p2) =>
            {
                return p1.BurstTime > p2.BurstTime
                ?
                p1.ArrivalTime > p2.ArrivalTime
                ?
                1
                :
                -1
                :
                -1;
            });
            Console.WriteLine("Process execution queue...");
            foreach(IProcessExample obj in processList)
            {
                Console.WriteLine($"ProcessName : {obj.ProcessName} \n" +
                    $"Arrival Time : {obj.ArrivalTime} \n" +
                    $"Burst Time : {obj.BurstTime}");
                Console.WriteLine();
            }
            //Counts
            //Head = 1, Tail = 2
            int i = 0;
            List<int> randomIntegers = new List<int>();
            Random rnd = new Random();
            while(i < 100)
            {
                randomIntegers.Add(rnd.Next(1, 3));
                i++;
            }
            Console.WriteLine("Number of Heads is : {0}", randomIntegers.Count(x => x == 1));
            Console.WriteLine("Number of Tailss is : {0}", randomIntegers.Count(x => x == 2));
            //Select: behaves almost like js map
            List<int> oneTo10 = new List<int>();
            oneTo10.AddRange(Enumerable.Range(1, 10));
            var oneTo10Squares = oneTo10.Select(x => Math.Pow(x, 2));
            Console.WriteLine("Square of 1 to 10 are: {0}", 
                string.Join(", ", oneTo10Squares));
            //Zip
            List<int> a1 = new List<int>() { 1, 2, 3 };
            List<int> a2 = new List<int>() { 4, 5, 6 };
            var zippedAs = a1.Zip(a2).ToList();
            //will return a pair of values
            Console.WriteLine("Zipped result of a1 and a2 is : {0}",
                string.Join(", ", zippedAs));
            var zippedAs2 = a1.Zip(a2, (x, y) => x + y).ToList();
            //will return the zipped addition
            Console.WriteLine("Zipped result of a1 and a2 is : {0}",
                string.Join(", ", zippedAs2));
            //Aggregate: behaves like reduce
            Console.WriteLine("Total of a1 is : {0}", a1.Aggregate((a, b) => a + b));
            //Other libraries
            Console.WriteLine("Average of a2 is : {0}", a2.AsQueryable().Average());
            Console.WriteLine("All > 3 : {0}", a1.All(x => x > 3 ));
            Console.WriteLine("Any > 3 : {0}", a2.Any(x => x > 3));
            //getting unique values
            Console.WriteLine("Different elements of oneTo10 with respect to a1: {0}",
                string.Join(",",oneTo10.Except(a1)));
        }
    }
}
