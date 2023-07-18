using System;
namespace LordOfTheRingConsole.Creatures
{
    public class SpiritualCreature : Magician
    {
        public string Spirit;
        public override void SpecialMove()
        {
            Console.WriteLine("Spiritual creatures are made by spirits and they have unlimited power.");
        }
    }
}