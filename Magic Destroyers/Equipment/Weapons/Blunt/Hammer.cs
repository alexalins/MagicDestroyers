using System;
using MagicDestroyers.Models;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    class Hammer : Weapon
    {
        public Hammer()
        {

        }

        public override void Buff()
        {
            this.Stun();
        }

        public void Stun() { Console.WriteLine("Stun"); }
    }
}
