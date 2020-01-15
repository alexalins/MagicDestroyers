using System;
using MagicDestroyers.Models.Enum;
using MagicDestroyers.Interfaces;

namespace MagicDestroyers.Models
{
    abstract class Character : IAttack, IDefend
    {
        public int Level { get; set; }
        public int HealthPoints { get; set; }
        public string Name { get; set; }
        public Faction Faction { get; set; }

        public abstract void Attack();

        public abstract void Defend();

        public abstract void SpecialAttack();
    }
}
