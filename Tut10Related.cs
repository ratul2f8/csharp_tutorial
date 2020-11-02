//Basically methods/properties of abstract classes are meant to be overwritten
using System;
using System.Collections.Generic;
using System.Text;

namespace DerekBanasCSharpTut
{
    //Abstract class
   abstract class Shape10
    {
        public string Name { get; set; }
        //you can also do regualr things
        public virtual void GetInfo()
        {
            Console.WriteLine($"This is  {Name}");
        }
        //abstract method - you must use it
        public abstract double Area();
    }
    //
}
