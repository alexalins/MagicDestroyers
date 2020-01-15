using System;
using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;

namespace MagicDestroyers.Characters.Spellcasters
{
    class Mage
    {
        public ClothRobe BodyArmor { get; set; }
        public Staff Weapon { get; set; }

        public Mage () { }

        public void ArcaneWrath () { }
        public void Firewall() { }
        public void Meditation() { }
    }
}
