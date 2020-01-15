using System;
using MagicDestroyers.Models;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    class Axe : Weapon
    {
        public Axe() { }

        public override void Buff()
        {
            this.HackNSlash();
        }

        public void HackNSlash() 
        {
            Console.WriteLine("HackNSlash");
        }
    }
}
