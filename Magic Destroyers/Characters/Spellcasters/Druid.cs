using System;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Blunt;

namespace MagicDestroyers.Characters.Spellcasters
{
    class Druid
    {
        public LightLeatherVest BodyArmor { get; set; }
        public Staff Weapon { get; set; }

        public Druid() { }

        public void Moonfire() {}
        public void Starburst() { }
        public void OneWithTheNature() { }
    }
}
