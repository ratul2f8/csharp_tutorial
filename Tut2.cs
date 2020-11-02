using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.ComponentModel;
using System.Linq;
//Arrays, Loop, Casting, StringBuilder, For, ForEach etc
namespace DerekBanasCSharpTut
{
    class Tut2
    {
        static void printArray(object[] objArray, string message)
        {
           foreach(object element in objArray)
            {
                Console.WriteLine("{0} : {1}", message, element);
            }
        }
        static int[] insertAnInteger(int[] parentArray, int whatToInsert, int whereToInsert)
        {
            int[] insertedArray = new int[parentArray.Length + 1];
            for(int i = 0; i < parentArray.Length; i++)
            {
                if(i >= whereToInsert)
                {
                    if(i == whereToInsert)
                    {
                        insertedArray[i] = whatToInsert;
                        insertedArray[i + 1] = parentArray[i];
                    }
                    else
                    {
                        insertedArray[i + 1] = parentArray[i];
                    }

                }
                else
                {
                    insertedArray[i] = parentArray[i];
                }
            }
            return insertedArray;
        }
        static int[] pushAnInteger(int[] randomIntegers, int whatToInsert)
        {
            var tempList = randomIntegers.ToList();
            tempList.Add(whatToInsert);
            return tempList.ToArray();
        }
        static void printIntegers(int[] intArray, string message)
        {
            foreach (object element in intArray)
            {
                Console.WriteLine("{0} : {1}", message, element);
            }
        }
        private static bool isGreaterThan10(int num)
        {
            return num > 10;
        }
        static void Sample(string[] args)
        {
            //implicit typing
            var intVar = 123;
            Console.WriteLine("Type of \'intVar\' is: {0}", intVar.GetType());
            //Arrays
            int[] favNums = new int[3];
            for(int i = 0; i < favNums.Length; i++)
            {
                favNums[i] = i;
            }
            string[] favNames = { "Bob", "Shelly", "Lana" };
            for (int i = 0; i < favNums.Length; i++)
            {
                Console.WriteLine(favNums[i]);
                Console.WriteLine(favNames[i]);
            }
            //declaring array in implicit fashion
            var impArray = new[] { "Bob", "Rubina", "Lucky" };
            for(int i = 0; i < impArray.Length; i++)
            {
                Console.WriteLine("Hello, {0}", impArray[i]);
            }
            //having multiple types of data in array
            object[] varietyArray = { "Paul", 123, 45.235F, 123246M };
            for(int i = 0; i < varietyArray.Length; i++)
            {
                Console.WriteLine("Type of {0} is : {1}", varietyArray[i], varietyArray[i].GetType());
            }
            //multi dimensional array
            string[,]  customerNames = new string[2, 2] { { "Bob", "Smith" }, { "Sally", "Marks" } };
            //access value
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Value at {0},{1} is: {2}", i, i, customerNames.GetValue(i, i));
            }
            //another way to access
            for(int i = 0; i < customerNames.GetLength(0); i++)
            {
                for (int j = 0; j < customerNames.GetLength(1); j++)
                {
                    Console.WriteLine(customerNames[i, j]);
                }
            }
            //for each
            printArray(varietyArray, "ForEach");
            //array methods
            int[] randomIntegers = { 1, 4, 9, 2 };
            Console.WriteLine("After Sorting..");
            Array.Sort(randomIntegers);
            printIntegers(randomIntegers, "Element");
            Console.WriteLine("After reversing");
            Array.Reverse(randomIntegers);
            printIntegers(randomIntegers, "Element");
            //write a program to push a value to an array
            Console.WriteLine("What To Push(Integer) ? ");
            int toPush = int.Parse(Console.ReadLine());
            randomIntegers = pushAnInteger(randomIntegers, toPush);
            printIntegers(randomIntegers, "Element");

            //write a program to insert a value in a specific position
            Console.WriteLine("Where to insert ? ");
            int where = int.Parse(Console.ReadLine());
            if(where >= randomIntegers.Length)
            {
                Console.WriteLine("Invalid Position!!");
            }
            else
            {
                Console.WriteLine("Enter What to Insert (Integer) ?");
                int whatToInsert = int.Parse(Console.ReadLine());
                randomIntegers = insertAnInteger(randomIntegers, whatToInsert, where);
                Console.WriteLine("After inserting the value \'{0}\' at position \'{1}\'", whatToInsert, where);
                printIntegers(randomIntegers, "Element");
            }
 
            
            //Copying an array
            int[] srcArray = { 1, 2, 3, 4, 5 };
            int length = 3;
            int startingIndex = 2;
            int[] destinationArray = { 7, 8, 9, 10, 11};
            Array.Copy(srcArray,startingIndex, destinationArray,startingIndex,length);
            printIntegers(destinationArray, "Copy");

            // Another way of creating an array
             Array fancyArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(fancyArray, 1);
            foreach(int m in fancyArray)
            {
                Console.WriteLine("Fancy : {0}", m);
            }
            //predicate
            //if not satisfies the condition it will return 0
            Console.WriteLine("First >10 element is : {0}", Array.Find(randomIntegers, isGreaterThan10));
            Console.WriteLine("First >10 element is/are : ");
            foreach(int element in Array.FindAll(randomIntegers, isGreaterThan10))
            {
                Console.WriteLine(element);
            }
            //String Builder
            StringBuilder sb1 = new StringBuilder("Hello World", 16);
            StringBuilder sb2 = new StringBuilder("Hello World", 256);
            Console.WriteLine("Capacity of sb1 : {0}", sb1.Capacity);
            Console.WriteLine("Capacity of sb2 : {0}", sb2.Capacity);
            Console.WriteLine("Length is : {0}", sb2.Length);
            sb2.AppendLine("\n Hi there!!!");
            sb2.Replace("Hi", "Welcome");

            CultureInfo enUS = new CultureInfo("en-US");
            StringBuilder bestCust = new StringBuilder("Bob Smith");
            sb2.AppendFormat(enUS, "Best Customer is : {0}", bestCust);
            Console.WriteLine(sb2.ToString());
        }

    }
}
