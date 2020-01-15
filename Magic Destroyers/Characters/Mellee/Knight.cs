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

        public void HolyBlow() { Console.WriteLine("HolyBlow"); }
        public void PurifySoul() { Console.WriteLine("PurifySoul"); }
        public void RighteousWings() { Console.WriteLine("RighteousWings"); }

        public override void Attack()
        {
            this.HolyBlow();
        }

        public override void Defend()
        {
            this.PurifySoul();
        }

        public override void SpecialAttack()
        {
            this.RighteousWings();
        }
    }
}
