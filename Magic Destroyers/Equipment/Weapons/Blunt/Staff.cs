﻿using System;
using MagicDestroyers.Models;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    class Staff :  Weapon
    {
        public Staff() { }

       
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
