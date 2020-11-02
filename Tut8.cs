using System;
using System.Collections.Generic;
using System.Text;

namespace DerekBanasCSharpTut
{
    class Dog: GeneralAnimal
    {
        private string Sound2 { set; get; } = "No Sound2";
        //Overwrite the inherited method
        //with polymorphism : public new void MakeSound()
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} makes sounds like {Sound} and {Sound2}");
        }
        //calling the constructor of parent class using the "base" parameter
        //equivalent to java super
        public Dog(string name = "No Name", string sound = "No Sound",
            string sound2 = "No Sound"): base(name, sound)
        {
            Sound2 = sound2;
        }
        //access inner class
        GeneralAnimal.HealthInfo healthInfo = new GeneralAnimal.HealthInfo();
        public void checkHealth(double height, double weight)
        {
            var status = healthInfo.isHealthy(height, weight);
            if (status)
            {
                Console.WriteLine($"{Name} is Healty");
            }
            else
            {
                Console.WriteLine($"{Name} is not Healty");
            }
        }
    }
    class Tut8
    {
        public static void Sample(string[] args)
        {
            GeneralAnimal cat = new GeneralAnimal(name: "Whisper");
            cat.setAnimalIdInfo("Emilly Willson", 12345);
            Dog dog = new Dog(name: "Dennis", sound: "Hmmm", sound2: "Grrr");
            dog.setAnimalIdInfo("Bob Brown", 46464);
            cat.MakeSound();
            dog.MakeSound();
            dog.Sound = "He he";
            dog.MakeSound();
            dog.PrintIdInfo();
            cat.PrintIdInfo();
            dog.checkHealth(11, 68);

            //polymorphism problem
            GeneralAnimal gen1 = new GeneralAnimal("Woobley", "Huuu..");
            GeneralAnimal gen2 = new Dog("Boobley", "Heeee..", "Geerrr..");
            gen1.MakeSound();
            gen2.MakeSound();// second sound will not be printed
            //to prevent this the method, that will be override should be marked as virtual
            //in parent class
             
        }
    }
}
