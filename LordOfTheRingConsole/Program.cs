using System;
using System.Dynamic;
using LordOfTheRingConsole.Creatures;

namespace LordOfTheRingConsole
{

    class Program{
        public static void Main(string[] args)
        {

            
            Human adam = new Human("prophet", "adam", "male", "hand", "paradise", 10000, true, true, true, true, false,
                1000, 100);
            SpiritualCreature Shelob = new SpiritualCreature("spyder", "shelob", "female", "posion and web",
                "Shelob possesses incredible size, strength, and cunning, making her a formidable predator.",
                "Despite her power, Shelob is not invincible and can be outwitted or overcome by brave and determined adversaries.",
                "Ungoliant", "none", 1000000, true, true, false, false, false);
            Human Angmar = new Human("magician", "angmar", "male", "Morgul blade", "Nazgûl", 10000000, true, true,
                false, true, false, 10000, 1000000);
            Angmar.Throw("Heal","Healing",50);
            Angmar.Summon("Skeleton",50);

        }
    }
}