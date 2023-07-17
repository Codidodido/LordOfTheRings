using System;
namespace LordOfTheRingConsole.Creatures
{
    public interface ISpell
    {
        void Throw(string spellName,string spellEffect,int spellPower);
    }
    public abstract class Magician : Immortal , ISpell
    {
        public string SpellName;
        public string SpellEffect;
        public int SpellPower;
        

        public void Throw(string spellName,string spellEffect , int spellPower)
        {
            SpellName = spellName;
            SpellEffect = spellEffect;
            SpellPower = spellPower;
            Console.WriteLine($"{Name} ({Race}) throwing '{SpellName}' spell which has '{SpellEffect}' effect and {SpellPower} power!");
        }
    }
}