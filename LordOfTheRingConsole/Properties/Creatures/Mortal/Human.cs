using System;

namespace LordOfTheRingConsole.Creatures
{
    
    public class Human : Mortal , ISpell , Isummon
    {
        
        public Human(string race,string name , string gender,string weapon , string clan,int power,bool isAlive,bool isTall,bool isBeauty,bool heroSide,bool isMortal, int age , int health):base( race, name ,  gender, weapon , clan,power,isAlive,isTall,isBeauty, heroSide,isMortal,age,health)
        {
            
        }
        public override void SpecialMove()
        {
            Console.WriteLine($"Humans fight with honor and good at diplomacy !");
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