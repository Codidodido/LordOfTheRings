using System;
namespace LordOfTheRingConsole.Creatures
{
    public class SpiritualCreature : Magician
    {
        public string Spirit { get; set; }

        public SpiritualCreature(string race, string name, string gender, string weapon,
            string specialAbility,
            string weakness, string spirit, string clan, int power, bool isAlive, bool isTall, bool isBeauty,
            bool heroSide,
            bool isMortal) : base(race, name, gender, weapon, specialAbility, weakness, clan, power, isAlive,
            isTall, isBeauty,
            heroSide, isMortal)
        {
            Spirit = spirit;
        }
        public override void SpecialMove()
        {
            Console.WriteLine("Spiritual creatures are made by spirits and they have unlimited power.");
        }
    }
}