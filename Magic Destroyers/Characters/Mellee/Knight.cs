using System;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Blunt;
using MagicDestroyers.Models;

namespace MagicDestroyers.Characters.Mellee
{
    class Knight : Melee
    {
        public Chainlink BodyArmor { get; set; }
        public Hammer Weapon { get; set; }

        public Knight()
        {

        }

        public void HolyBlow() { }
        public void PurifySoul() { }
        public void RighteousWings() { }
    }
}
