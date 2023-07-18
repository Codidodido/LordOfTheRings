using System;
namespace LordOfTheRingConsole.Creatures
{
    public class Valar : Magician
    {
        public Valar(string race, string name, string gender, string weapon, string specialAbility,
            string weakness, string clan, int power, bool isAlive, bool isTall, bool isBeauty, bool heroSide,
            bool isMortal) : base(race, name, gender, weapon, specialAbility,weakness, clan, power, isAlive, isTall, isBeauty,
            heroSide, isMortal)
        {
            
        }
        public override void SpecialMove()
        {
            Console.WriteLine("They are the greatest creatures in Middle-earth and known as gods !");
        }
    }
}