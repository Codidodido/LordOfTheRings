using System;
namespace LordOfTheRingConsole
{
    

    
    public abstract class Mortal  : Lorc
    {
        //lokc = LORD OF THE RINGS CREATURES
        
        public int Age { get; set; }
        public int Health { get; set; }
        
        public Mortal(string race,string name , string gender,string weapon , string clan,int power,bool isAlive,bool isTall,bool isBeauty,bool heroSide,bool isMortal, int age , int health):base( race, name ,  gender, weapon , clan,power,isAlive,isTall,isBeauty, heroSide,isMortal)
        {
            
            IsMortal = true;
            Age = age;
            Health = health;

        }
        
    }
}