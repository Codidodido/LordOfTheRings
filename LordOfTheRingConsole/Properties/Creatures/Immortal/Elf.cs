using System;

namespace LordOfTheRingConsole.Creatures
{
    public class Elf : Immortal , Isummon , ISpell
    {

        public Elf(string race, string name, string gender, string weapon, string element, string specialAbility,
            string weakness, string clan, int power, bool isAlive, bool isTall, bool isBeauty, bool heroSide,
            bool isMortal) : base(race, name, gender, weapon, weakness, clan, power, isAlive, isTall, isBeauty,
            heroSide, isMortal)
        {
            
        }
        public override void SpecialMove()
        {
            Console.WriteLine("Elves have a deep connection with music and song.\nTheir songs can have powerful effects on the world around them,\nfrom healing wounds to calming and inspiring their allies.");
        }
        public void Throw(string spellName,string spellEffect , int spellPower)
        {
            Console.WriteLine($"{Name} ({Race}) throwing '{spellName}' spell which has '{spellEffect}' effect and {spellPower} power!");
            
        }

        public void Summon(string creature, int power)
        {
            Console.WriteLine($"{Name} ({Race}) summon '{creature}' creature which has {power} power!");
        }
    }
}