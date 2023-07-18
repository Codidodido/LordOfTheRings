using System;
namespace LordOfTheRingConsole
{
    
    public abstract class Creature 
    {
        public string Gender { get; set; }
        public bool IsAlive{ get; set; }
        public string Race{ get; set; }
        public bool IsTall{ get; set; }
        public bool IsBeauty{ get; set; }
        public int Power{ get; set; }
        public bool HeroSide{ get; set; }
        public string Name{ get; set; }

        public Creature(string race,string name,string gender,int power,bool isAlive,bool isTall,bool isBeauty,bool heroSide)
        {
            Race = race;
            Name = name;
            Gender = gender;
            Power = power;
            IsAlive = isAlive;
            IsTall = isTall;
            IsBeauty = isBeauty;
            HeroSide = heroSide;
        }

    }
}