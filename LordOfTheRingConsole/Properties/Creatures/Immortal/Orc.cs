using System;

namespace LordOfTheRingConsole.Creatures
{
    public class Orc : Immortal
    {
        
        public override void SpecialMove()
        {
            Console.WriteLine("Orcs have heightened senses, especially in the dark and are more resistant to the corrupting influence of evil");
        }
    }
}