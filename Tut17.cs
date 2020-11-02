using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
//LINQ, From, Where, IEnumerable, OrderBy , Select, Inner Joins and Group joins
namespace DerekBanasCSharpTut
{
    class Tut17
    {
        static int[] QueryIntArray()
        {
            int[] numbers = { 1, 2, 3, 9, 5, 10, 12 };
            var greaterThanFour = from num in numbers
                                  where num > 4
                                  orderby num
                                  select num;
            Console.WriteLine("After Getting all the values greater than 4 : {0}",
                string.Join(",", greaterThanFour));
            //the magic thing where query is different
            numbers[0] = 25; //normally it will replace the value at pos 0 but here not
            //the query will also be updated  
            List<int> convList = greaterThanFour.ToList<int>();
            int[] convIntArray = convList.ToArray();
            return convIntArray;
        }
        static void QueryStringArray()
        {
            string[] dogs = {"K 9", "Brian Griffin", "Scooby Doo", "Old Yeller",
            "Rin Tin Tin", "Benji", "Lassie", "Charlie B. Barken", "Snoopy"};
            //get all the dogs name having a space in their name 
            //than, order by them in a descending order
            var dogSpaces = from dog in dogs
                            where dog.Contains(" ")
                            orderby dog descending
                            select dog;
            foreach(var dog in dogSpaces)
            {
                Console.WriteLine(dog);
            }
            
        }
        static void QueryAnimalData()
        {
            Animal17[] animalDatas = new []
            {
                new Animal17
                {
                    Name = "Heidi",
                    Height = .8,
                    Weight = 18,
                    AnimalID = 1
                },
                new Animal17
                {
                    Name = "Shrek",
                    Height = 4,
                    Weight =130,
                    AnimalID = 2
                },
                new Animal17
                {
                    Name = "Congo",
                    Height = 3.8,
                    Weight = 90,
                    AnimalID = 2
                }

            };
            Owner17[] ownerDatas = new[]
            {
                new Owner17
                {
                    Name = "Bella",
                    OwnerID = 1
                },
                new Owner17{
                    Name = "Belsimoore",
                    OwnerID = 2
                }
            };
            //inner join
            var innerJoin = from animal in animalDatas
                            join owner in ownerDatas on animal.AnimalID
                            equals owner.OwnerID
                            select new
                            {
                                AnimalName = animal.Name,
                                OwnerName = owner.Name
                            };
            foreach(var obj in innerJoin)
            {
                Console.WriteLine("{0} is owned by {1}", obj.AnimalName, obj.OwnerName);
            }
            //Groupjoin
            //group all animals under their owner
            var groupJoin = from owner in ownerDatas
                                   orderby owner.OwnerID
                                   join animal in animalDatas
                                   on owner.OwnerID equals animal.AnimalID
                                   into ownerGroup
                                   select new
                                   {
                                       Owner = owner.Name,
                                       Animals = from owner2 in ownerGroup
                                                 orderby owner2.Name
                                                 select owner2
                                   };
            foreach(var ownerGroup in groupJoin)
            {
                Console.WriteLine("Animals under the owner : {0}", ownerGroup.Owner);
                foreach(var animal in ownerGroup.Animals)
                {
                    Console.WriteLine(animal.Name);
                }
            }

        }
        static void QueryArrayList()
        {
            ArrayList famAnimals = new ArrayList()
            {
                new Animal17
                {
                    Name = "Heidi",
                    Height = .8,
                    Weight = 18
                },
                new Animal17
                {
                    Name = "Shrek",
                    Height = 4,
                    Weight =130
                },
                new Animal17
                {
                    Name = "Congo",
                    Height = 3.8,
                    Weight = 90
                }

            };
            //make the arrayList enumerable
            var famAnimalsEnum = famAnimals.OfType<Animal17>();
            var smallAnimals = from animal in famAnimalsEnum
                               where animal.Weight <= 90
                               orderby animal.Name
                               select animal;
            foreach(var anim in smallAnimals)
            {
                Console.WriteLine($"{anim.Name} weighs {anim.Weight} lbs");
            }
            //perform only select
            var animalObjs = from animal in famAnimalsEnum
                             select new
                             {
                                 animal.Name,
                                 animal.Height

                             };
            foreach(var anim in animalObjs)
            {
                Console.WriteLine("Height of {0} is : {1} inch", anim.Name, anim.Height);
            }
        }
        public static void Sample(string[] args)
        {
            QueryStringArray();
            Console.WriteLine("After inserting at pos 0 : {0}", 
                string.Join(", ", QueryIntArray()));
            QueryArrayList();
            QueryAnimalData();
        }
    }
}
