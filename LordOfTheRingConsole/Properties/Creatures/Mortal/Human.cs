using System;

namespace LordOfTheRingConsole.Creatures
{
    public class Human : Mortal
    {
        
        public override void SpecialMove()
        {
            Console.WriteLine($"Humans fight with honor and good at diplomacy and their special power is {Specialpower}!");
        }
    }
}