using System;
namespace LordOfTheRingConsole.Creatures
{
    public class Maiar : Magician
    {
        public Maiar(string race, string name, string gender, string weapon, string specialAbility,
            string weakness, string clan, int power, bool isAlive, bool isTall, bool isBeauty, bool heroSide,
            bool isMortal) : base(race, name, gender, weapon, specialAbility,weakness, clan, power, isAlive, isTall, isBeauty,
            heroSide, isMortal)
        {
            
        }
        public override void SpecialMove()
        {
            Console.WriteLine("The Maiar have the ability to change their physical form .");
        }
    }
}