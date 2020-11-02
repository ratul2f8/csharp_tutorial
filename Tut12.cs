using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
//Colle
namespace DerekBanasCSharpTut
{
    class Tut12
    {
        public static void Sample(string[] args)
        {
            #region ArrayListCode
            ArrayList aList = new ArrayList();
            aList.Add("Bob");
            Console.WriteLine($"Length of aList is : {aList.Count}");
            Console.WriteLine($"Capacity of aList is : {aList.Capacity}");
            ArrayList aList2 = new ArrayList();
            //appending raw idems
            aList2.AddRange(new object[] { "Mike", "Sally", "Shawn" });
            //appending a whole array list
            aList.AddRange(aList2);
            aList.Sort();
            aList.Reverse();
            aList.Insert(1, "Miata");
            ArrayList aList3 = aList.GetRange(1, 3);
            foreach(object obj in aList3)
            {
                Console.WriteLine(obj);
            }
            //removal
            Console.WriteLine("Before Removal..");
            foreach (object obj in aList2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("After Removal..");
            aList2.Remove("Sally");
            aList2.RemoveAt(1);
            foreach (object obj in aList2)
            {
                Console.WriteLine(obj);
            }
            //search
            Console.WriteLine("Position of Miata in aList is : {0}",
                aList.IndexOf("Miata"));
            //if you can also include a starting index to perform the search also
            Console.WriteLine("Position of Shawn in aList is : {0}",
                aList.IndexOf("Shawn"));
            Console.WriteLine("Position of Shawn in aList is : {0}",
                aList.IndexOf("Shawn", 1));//it will return -1 since the position of Shawn is 0
            //Convert the array list into regular old array
            string[] strArray = (string[]) aList.ToArray(typeof(string));

            #endregion
            #region Dictionary Code
            Dictionary<string, string> SuperHeroes = new Dictionary<string, string>();
            SuperHeroes.Add("Clark Kent", "Superman");
            SuperHeroes.Add("Bruce Wayne", "Batman");
            SuperHeroes.Add("Barry West", "Flash");
            foreach(KeyValuePair<string, string> pair in SuperHeroes)
            {
                Console.WriteLine($"{pair.Key} plays the role of {pair.Value}");
            }
            //removal
            SuperHeroes.Remove("Barry West");
            Console.WriteLine("After Removal");
            foreach (KeyValuePair<string, string> pair in SuperHeroes)
            {
                Console.WriteLine($"{pair.Key} plays the role of {pair.Value}");
            }
            Console.WriteLine("Does Barry West exist ? {0}",
                SuperHeroes.ContainsKey("Barry West"));
            Console.WriteLine("Does Bruce Wayne exist ? {0}",
                SuperHeroes.ContainsKey("Bruce Wayne"));
            SuperHeroes.Add("Gal Gadot", "Wonder Woman");
            SuperHeroes.TryGetValue("Gal Gadot", out string test);
            Console.WriteLine($"Gal Gadot plays the role of {test}");
            //remove everything
            SuperHeroes.Clear();
            Console.WriteLine("After clearing all..");
            Console.WriteLine("Length of the SuperHeroes dict. is: {0}", SuperHeroes.Count);
            #endregion
            #region Queue Code
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            //pull a value
            Console.WriteLine("First item in queue is {0}", queue.Peek());
            //remove a value
            queue.Dequeue();
            Console.WriteLine("Elments of the queue after removal ..");
            foreach(object obj in queue)
            {
                Console.WriteLine("Element" +
                    " : {0}", obj);
            }
            //Convert queue into array
            object[] quObjs = queue.ToArray();
            foreach (object obj in quObjs)
            {
                Console.WriteLine("Type: {0}" +
                    " : {1}",obj.GetType(), obj);
            }
            //Convert queue into ArrayList
            ArrayList quArL = new ArrayList(queue);
            foreach (object obj in quArL)
            {
                Console.WriteLine("Type: {0}" +
                    " : {1}", obj.GetType(), obj);
            }
            #endregion
            #region Stack Code
            Stack stack = new Stack();
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            foreach(object obj in stack)
            {
                Console.WriteLine(" Stack elem : {0}", obj);
            }
            //After Popping
            Console.WriteLine("Fist element of the stack : {0}", stack.Peek());
            stack.Pop();
            foreach (object obj in stack)
            {
                Console.WriteLine(" Stack elem : {0}", obj);
            }
            //join
            Console.WriteLine("{0}", string.Join(",", quObjs));
            #endregion
        }
    }
}
