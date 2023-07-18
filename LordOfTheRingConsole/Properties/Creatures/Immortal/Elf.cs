using System;

namespace LordOfTheRingConsole.Creatures
{
    public class Elf : Immortal , Isummon , ISpell
    {
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