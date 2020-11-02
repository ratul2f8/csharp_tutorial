using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
//Generics
namespace DerekBanasCSharpTut
{
    class Tut13
    {
        //generic struct
        public struct Rectangle13<T>
        {
            private T length, width;
            public Rectangle13(T w, T l)
            {
                length = l;
                width = w;
            }
            public T Length
            {
                get { return length; }
                set
                {
                    length = value;
                }
            }
            public T Width
            {
                get { return width;  }
                set
                {
                    width = value;
                }
            }
            public void GetArea()
            {
                double x = Convert.ToDouble(length);
                double y = Convert.ToDouble(width);
                Console.WriteLine("Area is : {0}", x * y);
            }
        }

        public static void Sample(string[] args)
        {
            List<Animal13> list = new List<Animal13>();
            list.Add(new Animal13()
            {
                Name = "Sally"
            });
            list.Add(new Animal13("Bob"));
            list.Add(new Animal13("Doug"));
            list.Insert(1, new Animal13("Helios"));
            Console.WriteLine("Total number of animals : {0}", list.Count);
            list.RemoveAt(2);
            Console.WriteLine("After Removal");
            Console.WriteLine("Total number of animals : {0}", list.Count);
            int x = 5, y = 7;
            Animal13.GetSumRef(ref x, ref y);
            Animal13.GetSum( x, y);
            //Simillarly
            string strX = "5", strY = "7";
            Animal13.GetSum(strX, strY);
            //generic struct
            Rectangle13<int> rect1 = new Rectangle13<int>(50, 70);
            rect1.GetArea();
            Rectangle13<string> rect2 = new Rectangle13<string>("50", "70");
            rect2.GetArea();
        }
    }
}
