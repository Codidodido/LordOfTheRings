using System;
namespace LordOfTheRingConsole.Creatures
{
    public class Dwarf : Mortal
    {
        public Dwarf(string race,string name , string gender,string weapon , string clan,int power,bool isAlive,bool isTall,bool isBeauty,bool heroSide,bool isMortal, int age , int health):base( race, name ,  gender, weapon , clan,power,isAlive,isTall,isBeauty, heroSide,isMortal,age,health)
        {
            
        }
        public override void SpecialMove()
        {
            Console.WriteLine("Dwarfs are great at making weapons and fishing!");
        }
    }
}