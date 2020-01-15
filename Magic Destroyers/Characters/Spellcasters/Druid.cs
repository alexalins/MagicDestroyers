using System;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Blunt;
using MagicDestroyers.Models;

namespace MagicDestroyers.Characters.Spellcasters
{
    class Druid : Spellcaster
    {
        public LightLeatherVest BodyArmor { get; set; }
        public Staff Weapon { get; set; }

        public Druid() { }

        public void Moonfire() { Console.WriteLine("Moonfire"); }
        public void Starburst() { Console.WriteLine("Starburst"); }
        public void OneWithTheNature() { Console.WriteLine("OneWithTheNature"); }

        public override void Attack()
        {
            this.Moonfire();
        }

        public override void Defend()
        {
            this.Starburst();
        }

        public override void SpecialAttack()
        {
            this.OneWithTheNature();
        }
    }
}
