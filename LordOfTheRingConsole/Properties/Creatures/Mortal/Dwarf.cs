using System;
namespace LordOfTheRingConsole.Creatures
{
    public class Dwarf : Mortal
    {
        
        public override void SpecialMove()
        {
            Console.WriteLine("Dwarfs are great at making weapons and fishing!");
        }
    }
}