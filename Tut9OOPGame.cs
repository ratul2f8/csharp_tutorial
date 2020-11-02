using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DerekBanasCSharpTut
{
    class Tut9OOPGame
    {
        public static void Sample(string[] args)
        {
            Warrior Maximus = new Warrior("Maximus", 1000, 120, 40);
            Warrior Bob = new Warrior("Bob", 1000, 120, 40);
            Battle.StartFight(Maximus, Bob);
        }
    }
}
