using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using System.Collections;

namespace DerekBanasCSharpTut
{
    class Animal16
    {
        public string Name { get; set; } = "No Name";
        public Animal16(string name = "No Name")
        {
            Name = name;
        }
    }

    class AnimalFarm : IEnumerable
    {
        public List<Animal16> animalList = new List<Animal16>();
        public AnimalFarm(List<Animal16> animalList)
        {
            this.animalList = animalList;
        }
        public AnimalFarm()
        {

        }
        //indexers
        public Animal16 this[int index]
        {
            get { return (Animal16)animalList[index];  }
            set
            {
                animalList.Insert(index, value);
            }
        }
        //count
        public int CountAnimals
        {
            get { return animalList.Count; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return animalList.GetEnumerator();
        }

    } 

}