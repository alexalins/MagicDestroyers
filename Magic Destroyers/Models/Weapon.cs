using System;
using MagicDestroyers.Interfaces;

namespace MagicDestroyers.Models
{
    abstract class Weapon : IBuff
    {
        public int Damage { get; set; }

        public abstract void Buff();
    }
}
