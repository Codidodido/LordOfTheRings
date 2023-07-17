using System;
namespace LordOfTheRingConsole
{
    

    
    public abstract class Mortal  : Lorc
    {
        //lokc = LORD OF THE RINGS CREATURES
        
        public int Age;
        public int Health;
        public void Create(string race,string name , string gender,string weapon , string specialPower , string clan,int power,int age, int health,bool isAlive,bool isTall,bool isBeauty,bool heroSide ,bool isMortal)
        {
            Race = race;
            Name = name;
            Gender = gender;
            Weapon = weapon;
            Specialpower = specialPower;
            Clan = clan;
            Power = power;
            Age = age;
            Health = health;
            IsAlive = isAlive;
            IsTall = isTall;
            IsBeauty = isBeauty;
            HeroSide = heroSide;
            IsMortal = isMortal;
        }
        public void Situation()
        {
            Console.WriteLine($"Situation of {Name} ({Race}):\n\tAge: {Age}\n\tHealth: {Health}\n\tIs Alive: {IsAlive}");
        }
    }
}