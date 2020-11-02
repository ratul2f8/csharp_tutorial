using System;
using System.Collections.Generic;
using System.Text;
//Custom Collections,Indexersd, Enumerator, Operator overloading, Custom Casting,
//Anonymous Types
namespace DerekBanasCSharpTut
{
    class Tut16
    {
        public static void Sample(string[] args)
        {
            AnimalFarm animalFarm = new AnimalFarm();
            animalFarm[0] = new Animal16("Wilbur");
            animalFarm[1] = new Animal16("Gander");
            animalFarm[2] = new Animal16("Templeton");
            animalFarm[3] = new Animal16("Luna");
            foreach (Animal16 anim in animalFarm)
            {
                Console.WriteLine(anim.Name);
            }
            //implicit, explicit, operator overload
            Box box1 = new Box(1, 2, 3);
            Box box2 = new Box(4, 5, 6);
            Box box3 = box1 + box2;
            Console.WriteLine("Combined box info : {0}", box3);
            Console.WriteLine("Box int : {0}", (int)box3);
            Console.WriteLine("Box 4 : {0}", (Box)5);
            //anonymous typing
            var toyObj = new
            {
                Name = "Shopkins",
                Price = 4.99
            };
            Console.WriteLine($"Price of {toyObj.Name} is  {toyObj.Price}");
            //you can also convert/store them into an array
            var toyArray = new[]
            {
                new
                {
                    Name = "Legos",
                    Price = 9.99
                },
                new
                {
                    Name = "Yo-Kai Pack",
                    Price =4.99
                }
            };
            foreach(var toy in toyArray)
            {
                Console.WriteLine($"Price of {toy.Name} is  {toy.Price}");
            }
        }
    }
}
