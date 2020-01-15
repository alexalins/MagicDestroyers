using System;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;
using MagicDestroyers.Models;

namespace MagicDestroyers.Characters.Mellee
{
    class Warrior : Melee
    {
        public Chainlink bodyArmor { get; set; }
        public Axe weapon { get; set; }

        public Warrior() { }

        public void Strike() { Console.WriteLine("Strike"); }
        public void Execute() { Console.WriteLine("Execute"); }
        public void SkinHarden() { Console.WriteLine("SkinHarden"); }

        public override void Attack()
        {
            this.Strike();
        }

        public override void Defend()
        {
            this.Execute();
        }

        public override void SpecialAttack()
        {
            this.SkinHarden();
        }
    }
}
