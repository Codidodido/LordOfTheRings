using System;
namespace LordOfTheRingConsole
{
    
    public class Feature : Creature
    {
        
        public string Name;
        public string Weapon;
        public string Specialpower;

        public void Features()
        {
            Console.WriteLine($"Creature Name: {Name}\nCreature Special power: {Specialpower}\nCreature Weapon: {Weapon}");
        }

        
        
    }
}