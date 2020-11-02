using System;

namespace DerekBanasCSharpTut
{
    class Warrior
    {
        //Properties are  -Name, Health, Maximum Attack, Maximum Block
        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        public double AttkMax { get; set; } = 0;
        public double BlkMax { get; set; } = 0;
        //Random Numbers
        Random rnd = new Random();
        //contructor
        public Warrior(string name = "Warrior", double health = 0, double maxAttack = 0,
        double maxBlock = 0)
        {
            Name = name;
            Health = health;
            AttkMax = maxAttack;
            BlkMax = maxBlock;
        }
        //Attack
        //Generate a random value from 1 to Maximum Attack
        public int Attack()
        {
            return rnd.Next(1, (int)AttkMax);
        }
        //Block
        //Generate a ra ndom value from  1 to Maximum Block
        public int Block()
        {
            return rnd.Next(1, (int)BlkMax);
        }
    }
}
