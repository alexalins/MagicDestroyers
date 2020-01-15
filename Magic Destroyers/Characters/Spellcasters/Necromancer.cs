using System;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using MagicDestroyers.Models;


namespace MagicDestroyers.Characters.Spellcasters
{
    class Necromancer : Spellcaster
    {
        public LightLeatherVest BodyArmor { get; set; }
        public Sword Weapon { get; set; }

        public Necromancer() { }

        public void ShadowRage() { Console.WriteLine("ShadowRage"); }
        public void VampireTouch() { Console.WriteLine("VampireTouch"); }
        public void BoneShield() { Console.WriteLine("BoneShield"); }

        public override void Attack()
        {
            this.ShadowRage();
        }

        public override void Defend()
        {
            this.VampireTouch();
        }

        public override void SpecialAttack()
        {
            this.BoneShield();
        }
    }
}
