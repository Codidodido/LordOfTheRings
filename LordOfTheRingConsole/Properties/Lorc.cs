using System;
namespace LordOfTheRingConsole
{
    public interface IAttack
    {
        void Attack(Lorc defender);
    }
    public interface IBreath
    {
        void Breath();
    }

    public interface IEat
    {
        void Eat(string food);
    }

    public interface IDrink
    {
        void Drink(string drink);
    }

    public interface IWalk
    {
        void Walk(int x, int y,int z);
    }

    public interface ISex
    {
        void Sex(Lorc partner);
    }
    //Lokc = Lord Of The Rings creatures
    public abstract class Lorc : Feature , IAttack , IBreath , IEat
    {
        public string Clan;
        public bool IsMortal;
        public abstract void SpecialMove();
        //----
        public void Attack(Lorc defender)
        {
            Console.WriteLine($"{Name} ({Race}) will attack with {Weapon} which has power: {Power}!");
            Console.WriteLine($"{defender.Name} ({defender.Race}) will defend with {defender.Weapon} which has power: {defender.Power}!");

            if (!IsMortal && defender.IsMortal)
            {
                Console.WriteLine($"{Name} ({Race}) wins because it is mortal.");
            }
            
            else if(Power>defender.Power)
            {
                Console.WriteLine($"{Name} ({Race}) wins because it is more powerful.");
            }
            else
            {
                Console.WriteLine($"{defender.Name} ({defender.Race}) wins all the way !");
            }
        }
        //----
        public void Breath()
        {
            Console.WriteLine($"{Name} ({Race}) feels air comes and outs ... .");
        }
        //----
        public void Eat(string food)
        {
            Console.WriteLine($"{Name} ({Race}) eats {food}");
        }
        //----
        public void Drink(string drink)
        {
            Console.WriteLine($"{Name} ({Race}) drinks {drink}");
        }
        //----
        public void Walk(int x, int y, int z)
        {
            Console.WriteLine($"{Name} ({Race}) walks to coordinates (x:{x},y:{y},z:{z})");
        }
        //---
        public void Sex(Lorc partner)
        {
            Console.WriteLine($"{Name} ({Race}) has sex with {partner.Name} ({partner.Race})");
        }
        
    }
}