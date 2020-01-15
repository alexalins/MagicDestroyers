using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using MagicDestroyers.Models;
using System;

namespace MagicDestroyers.Characters.Mellee
{
    class Assassin : Melee
    {
        public LightLeatherVest BodyArmor { get; set; }
        public Sword Weapon { get; set; }

        public Assassin()
        {

        }
        public Assassin(int level, string name)
        {
            this.Level = level;
            this.Name = name;
        }

        public Assassin(int level, string name, int healthPoints)
        {
            this.Level = level;
            this.Name = name;
            this.HealthPoints = healthPoints;
        }

        public Assassin(int abilityPoints, int healthPoints, int level, string name, string faction, LightLeatherVest bodyArmor, Sword weapon)
        {
            this.AbilityPoints = 10;
            this.HealthPoints = 100;
            this.Level = 4;
            this.Name = "Alius";
            this.Faction = Faction.Melee;
            this.BodyArmor = new LightLeatherVest();
            this.Weapon = new Sword();
        }

        public void Raze()
        {

        }

        public void BleedToDeath()
        {

        }

        public void Survival()
        {

        }

    }
}
