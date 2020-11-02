using System;
using System.Collections.Generic;
using System.Text;

namespace DerekBanasCSharpTut
{
    class Animal17
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double AnimalID { get; set; } = 1;
        public Animal17(string name, double height, double weight)
        {
            Name = name;
            Height = height;
            Weight = weight;
        }
        public Animal17()
        {
           
        }
        public override string ToString()
        {
            return String.Format("{0} weighs {1}lbs and  {2}inches tall", 
                Name, Weight, Height);
        }
    }
    class Owner17
    {
        public string Name { get; set; }
        public int OwnerID { get; set; }
    }
}
