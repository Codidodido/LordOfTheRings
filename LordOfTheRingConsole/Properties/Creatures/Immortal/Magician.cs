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
        public string SpecialAbility { get; set; }
        private string Element { get; set; }

        public Magician(string race,string name , string gender,string weapon ,string specialAbility,string weakness , string clan,int power,bool isAlive,bool isTall,bool isBeauty,bool heroSide ,bool isMortal):base( race, name ,  gender, weapon , weakness,clan,power,isAlive,isTall,isBeauty, heroSide,isMortal)
        {
            SpecialAbility = specialAbility;
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