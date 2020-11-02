//OOP tutorial part 2
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace DerekBanasCSharpTut
{
    class Tut7
    {
        class Animal
        {
            private string name;
            private string sound;
            public const string Shelter = "Nino's Home";
            //can only be changed inside a constructor
            //And once changed, it can't be changed in runtime
            public readonly int idNum;
            public void MakeSound()
            {
                Console.WriteLine("{0} says {1}", this.name, this.sound);
            }
            //another way of passing default parameters in constructors
            // if Animal() is called then pass and call the function with ":this" parameters
            // in other generic constructor method
            public Animal():
                this("No Name", "No Sound") { }
            public Animal(string name)
                :this(name, "No Sound") { }
            public Animal(string name, string sound)
            {
                this.setName(name);
                Sound = sound;
                NumOfAnimals = 1;
                Owner = "Symon";
                Random rnd = new Random();
                idNum = rnd.Next(1, 2147483640);

            }
            //the csharp way of writing getter and setter
            public string Sound
            {
                private set
                {
                    this.sound = value;
                }
                get
                {
                    return this.sound;
                }
            }
            //another csharp way
            public string Owner { get; set; } = "No Owner";
            public static int numOfAnimals = 0;
            public static int NumOfAnimals
            {
                get
                {
                    return numOfAnimals;
                }
                set
                {
                    numOfAnimals += value;
                }
            }
            //as usual getter and setter
            public void setName(string name)
            {
                //check that the name doesn't have any character
                if (!name.Any(char.IsDigit))
                {
                    this.name = name;
                }
                else
                {
                    this.name = "No Name";
                    Console.WriteLine("Name can't contain a digit!");
                }
            }
            public string getName()
            {
                return this.name;
            }

        }
        public static void Sample(string[] args)
        {
            Animal Cat = new Animal("Whisper", "Meow");
            Console.WriteLine("The owner of {0} is : {1}", Cat.getName(), Cat.Owner);
            Cat.Owner = "Helem";
            Console.WriteLine("The owner of {0} is : {1}", Cat.getName(), Cat.Owner);
            Animal Cat1 = new Animal("Don");
            Console.WriteLine("{0} says {1}", Cat1.getName(), Cat1.Sound);
            Console.WriteLine("ID of {0} is : {1}",Cat.getName(), Cat.idNum);
            Console.WriteLine("Total Number of Animal Instances : {0}", Animal.NumOfAnimals);
        }
    }
}
