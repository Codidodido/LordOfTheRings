using System;
using System.ComponentModel.Design.Serialization;
using System.Threading;

namespace LordOfTheRingConsole
{
    
    public abstract class Immortal : Lorc
    {
        public string Weakness { get; set; }
        public Immortal(string race,string name , string gender,string weapon , string weakness , string clan,int power,bool isAlive,bool isTall,bool isBeauty,bool heroSide ,bool isMortal):base( race, name ,  gender, weapon , clan,power,isAlive,isTall,isBeauty, heroSide,isMortal)
        {
            isMortal = false;
            Weakness = weakness;
        }
        /*
        public void Create(string race,string name , string gender,string weapon , string specialPower , string weakness , string clan,int power,bool isAlive,bool isTall,bool isBeauty,bool heroSide ,bool isMortal)
        {
            Race = race;
            Name = name;
            Gender = gender;
            Weapon = weapon;
            
            Weakness = weakness;
            Clan = clan;
            Power = power;
            IsAlive = isAlive;
            IsTall = isTall;
            IsBeauty = isBeauty;
            HeroSide = heroSide;
            IsMortal = isMortal;
        }
        */
        
        
    }
}