using System;
using System.Dynamic;
using LordOfTheRingConsole.Creatures;

namespace LordOfTheRingConsole
{

    class Program{
        public static void Main(string[] args)
        {

            Human first = new Human();
            Human second = new Human();
            Orc bad = new Orc();
            Valar god = new Valar();
            
            
            
            bad.Attack(first);
            first.Attack(second);
            god.Attack(bad);
            god.Breath();
            god.Throw("Heal","Healing",50);
            first.Breath();
            first.Drink("Water");
            first.Eat("Beaf");
            first.Sex(second);
            
        }
    }
}