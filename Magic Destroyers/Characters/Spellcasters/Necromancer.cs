using System;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;

namespace MagicDestroyers.Characters.Spellcasters
{
    class Necromancer
    {
        public LightLeatherVest BodyArmor { get; set; }
        public Sword Weapon { get; set; }

        public Necromancer() { }

        public void ShadowRage() { }
        public void VampireTouch() { }
        public void BoneShield() { }
    }
}
