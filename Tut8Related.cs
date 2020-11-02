//inheritance class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DerekBanasCSharpTut
{
    class IdAndOwner
{
    public string Owner { set; get; } = "No Owner";
    public int Id { set; get; } = 0;
}
//If you don't want to enable inheritance just type "sealed" keyword before the class
//declaration
class GeneralAnimal
{
    //using aggregator
    IdAndOwner animalIdInfo = new IdAndOwner();
    public void setAnimalIdInfo(string owner, int id)
    {
        animalIdInfo.Owner = owner;
        animalIdInfo.Id = id;
    }
    public void PrintIdInfo()
    {
       Console.WriteLine($"{Name}'s ID is {animalIdInfo.Id} and is owned by" +
           $" {animalIdInfo.Owner}");
    }
    private string name;
    protected string sound;
    public String Sound
    {
        get
        {
            return this.sound;
        }
        set
        {
            if(value.Length > 10)
            {
                this.sound = "No Sound";
                Console.WriteLine("Sound is too long..");
            }
            this.sound = value;
        }
    }
        //with ploymorphism : publicvoid MakeSound()
        public virtual void MakeSound()
    {
        Console.WriteLine($"{Name} makes {Sound} type of sound");
    }
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (value.Any(char.IsDigit))
            {
                name = "No Name";
                Console.WriteLine("Name can't contain digits");
                    
            }
            else
            {
                name = value;
            }
        }
    }
    public GeneralAnimal():this("No Name", "No Sound") { }
    public GeneralAnimal( string name) : this(name, "No Sound") { }
    public GeneralAnimal(string name, string sound)
    {
        Name = name;
        Sound = sound;
    }
    
        public class HealthInfo
        {
            public bool isHealthy(double height, double weight)
            {
                if((height/weight) <= 0.17)
                {
                    return true;
                }
                return false; 
            }
        }

}
}
