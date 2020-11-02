using System;
using System.Collections.Generic;
using System.Text;

namespace DerekBanasCSharpTut
{
    class Battle
    {
        //Start fight
        //Loop hrough the battle untill one dies
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {
                if(GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if(GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }
        //Get Attck Result
        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warriorAAttkAmt = warriorA.Attack();
            double warriorBBlkAmt = warriorB.Block();

            double damageToWarriorB = warriorAAttkAmt - warriorBBlkAmt;
            if (damageToWarriorB > 0)
            {
                warriorB.Health = warriorB.Health - damageToWarriorB;
            }
            else damageToWarriorB = 0;
            Console.WriteLine($"{warriorA.Name} attacks {warriorB.Name} " +
                $"and deals {damageToWarriorB} damage");
            Console.WriteLine($"{warriorB.Name} has {warriorB.Health} health");
            if(warriorB.Health <= 0)
            {
                Console.WriteLine($"{warriorB.Name} has died and {warriorA.Name} is victorious");
                return "Game Over";
            }
            else
            {
                return "Fight Again";
            }
        }
    }
}
