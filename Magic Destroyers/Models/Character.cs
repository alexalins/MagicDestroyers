using System;
using MagicDestroyers.Models.Enum;

namespace MagicDestroyers.Models
{
    class Character
    {
        public int Level { get; set; }
        public int HealthPoints { get; set; }
        public string Name { get; set; }
        public Faction Faction { get; set; }
    }
}
