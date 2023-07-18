using System;
namespace LordOfTheRingConsole.Creatures
{
    public interface ISpell
    {
        void Throw(string spellName,string spellEffect,int spellPower);
    }

    public interface Isummon
    {
        void Summon(string creature, int power);
    }
    public abstract class Magician : Immortal , ISpell , Isummon
    {
        public string SpecialAbility;
        public string Element;

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