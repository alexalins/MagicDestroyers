using System;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;

namespace MagicDestroyers.Characters.Mellee
{
    class Warrior
    {
        public Chainlink bodyArmor { get; set; }
        public Axe weapon { get; set; }

        public Warrior() { }

        public void Strike() { }
        public void Execute() { }
        public void SkinHarden() { }
    }
}
