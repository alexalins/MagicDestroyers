using System;
using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;
using MagicDestroyers.Models;


namespace MagicDestroyers.Characters.Spellcasters
{
    class Mage : Spellcaster
    {
        public ClothRobe BodyArmor { get; set; }
        public Staff Weapon { get; set; }

        public Mage () { }

        public void ArcaneWrath() { Console.WriteLine("ArcaneWrath"); }
        public void Firewall() { Console.WriteLine("Firewall"); }
        public void Meditation() { Console.WriteLine("Meditation"); }

        public override void Attack()
        {
            this.ArcaneWrath();
        }

        public override void Defend()
        {
            this.Firewall();
        }

        public override void SpecialAttack()
        {
            this.Meditation();
        }
    }
}
