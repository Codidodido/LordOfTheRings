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
            first.Create("Human","David","male","sword","nothing","abcd",30,24,100,true,true,true,true,true);
            second.Create("Human","Elizabeth","female","knife","nothing","efgh",20,18,100,true,true,true,true,true);
            bad.Create("Orc","DODI","male","mace","nothing","sunlight","boom",20,true,false,false,false,false);
            god.Create("Valar","Zeus","male","spear","magic","nothing","olympus",10000,true,true,false,true,false);
            
            
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