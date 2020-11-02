//object orient programming starts
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.Serialization;
using System.Text;

namespace DerekBanasCSharpTut
{
    class Animal
    {
        public string name, sound;
        static int numOfAnimals = 0;
        public Animal()
        {
            this.name = "No Name";
            this.sound = "No Sound";
            //note the access of static fields
            Animal.numOfAnimals++;
        }
        public Animal( string name = "No Name", string sound = "No Sound")
        {
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", this.name, this.sound);
        }
        //globally shared between all instances
        public static int getNumOfAnimals()
        {
            return Animal.numOfAnimals;
        }

    }
    class Tut6
    {
        static void Sample(string[] args)
        {
            Animal fox = new Animal(name: "Fox", sound: "Raww");
            Console.WriteLine("Numbet of Animals : {0}", Animal.getNumOfAnimals());
            fox.MakeSound();
            Animal Cow = new Animal(name: "Goru", sound: "Hambaaa");
            Cow.MakeSound();
            //concept of static class
            Console.WriteLine("Area of a circle having the radius of 5 units is : {0:0.000}",
                ShapeMath.GetArea("Circle", length2: 5));
            //nullable types
            //by default assigning with null is not supported
            int? nullVal = null;
            if (nullVal == null)
            {
                Console.WriteLine("The value is null");
            }
            else{
                Console.WriteLine("Initialization is a better practice");
            }
            if (!nullVal.HasValue)
            {
                Console.WriteLine("The value is null");
            }
        }
    }
}
