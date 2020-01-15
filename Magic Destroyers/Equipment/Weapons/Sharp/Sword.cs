using System;
using MagicDestroyers.Models;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    class Sword : Weapon
    {
        public Sword() { }

        public void Empower() 
        {
            Console.WriteLine("Empower");
        }

        public override void Buff()
        {
            this.Empower();
        }
    }
}
