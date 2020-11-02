using System;
using System.Collections.Generic;
using System.Text;
//interface
namespace DerekBanasCSharpTut
{
    //interface itself
    interface IDrivable
    {
        int Wheels { get; set; }
        double Speed { get; set; }
        void Move();
        void Stop();
    }
    class Vehicle : IDrivable
    {
        public string Brand { get; set; } = "No Brand";
        public int Wheels { get; set ; }
        public double Speed { get; set; }
        public void Move()
        {
            Console.WriteLine($"{Brand} Moves at {Speed} MPH");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} Stops now.");
            Speed = 0;
        }
        //constructor
        public Vehicle(string brand = "No Brand", int wheels = 0, double speed = 0)
        {
            Speed = speed;
            Brand = brand;
            Wheels = wheels;
        }
    }
    class Tut11
    {
        public static void Sample(string[] args)
        {
            Vehicle Skoda = new Vehicle("Skoda", 4, 180);
            if(Skoda is IDrivable)
            {
                Skoda.Move();
                Skoda.Stop();
            }
            else
            {
                Console.WriteLine($"{Skoda.Brand} can't be drivable");
            }
            IElectronicDevice TV = TVRemote.GetDevice();
            PowerButton powBt = new PowerButton(TV);
            powBt.Execute();
            powBt.Undo();
        }
    }
}
