using System;

namespace LordOfTheRingConsole.Creatures
{
    public class Orc : Immortal
    {
        public Orc(string race, string name, string gender, string weapon, string element, string specialAbility,
            string weakness, string clan, int power, bool isAlive, bool isTall, bool isBeauty, bool heroSide,
            bool isMortal) : base(race, name, gender, weapon, weakness, clan, power, isAlive, isTall, isBeauty,
            heroSide, isMortal)
        {
            
        }
        public override void SpecialMove()
        {
            Console.WriteLine("Orcs have heightened senses, especially in the dark and are more resistant to the corrupting influence of evil");
        }
    }
}