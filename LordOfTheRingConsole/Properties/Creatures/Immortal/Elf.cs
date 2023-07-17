using System;

namespace LordOfTheRingConsole.Creatures
{
    public class Elf : Immortal
    {
        public override void SpecialMove()
        {
            Console.WriteLine("Elves have a deep connection with music and song.\nTheir songs can have powerful effects on the world around them,\nfrom healing wounds to calming and inspiring their allies.");
        }
    }
}