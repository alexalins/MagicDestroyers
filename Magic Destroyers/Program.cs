using System;
using MagicDestroyers.Models;
using MagicDestroyers.Characters.Mellee;
using MagicDestroyers.Characters.Spellcasters;
using System.Collections.Generic;

namespace MagicDestroyers
{
    class Program
    {
        static void Main(string[] args)
        {
            Character warrior = new Warrior();
            Character knight = new Knight();
            Character assassin = new Assassin();
            Character mage = new Mage();
            Character necromancer = new Necromancer();
            Character druid = new Druid();

            List<Character> meleeTeam = new List<Character>();
            List<Character> spellTeam = new List<Character>();

            meleeTeam.Add(warrior);
            meleeTeam.Add(knight);
            meleeTeam.Add(assassin);

            spellTeam.Add(mage);
            spellTeam.Add(necromancer);
            spellTeam.Add(druid);

            meleeTeam.ForEach(melee => { melee.Attack(); });
        }
    }
}
