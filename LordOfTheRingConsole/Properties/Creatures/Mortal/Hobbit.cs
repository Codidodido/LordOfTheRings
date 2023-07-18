using System;
namespace LordOfTheRingConsole.Creatures
{
    public class Hobbit : Mortal
    {
        public Hobbit(string race,string name , string gender,string weapon , string clan,int power,bool isAlive,bool isTall,bool isBeauty,bool heroSide,bool isMortal, int age , int health):base( race, name ,  gender, weapon , clan,power,isAlive,isTall,isBeauty, heroSide,isMortal,age,health)
        {
            
        }
        public override void SpecialMove()
        {
            Console.WriteLine("Hobbits are peaceful and funny creatures who enjoys from drinking all the time!");
        }
    }
}