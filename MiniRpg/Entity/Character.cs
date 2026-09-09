using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using MiniRpg.Entity;
using MiniRpg.Asset;

namespace MiniRpg.Entity
{
    internal class Character : Entity
    {
        private string[] jobs = { "Tank", "Mage", "DPS" };
        private string[] skills;        
        private string myJob;        

        
        public string Job { get { return myJob; } }        
        public string[] Skill { get { return skills;} }

        public Character(string name, int damage, int maxHp, int currentHp, int maxMana, int currentMana, Random random, int maxDefense
            , string job, string[] skills)
            : base(name, damage, maxHp, currentHp, maxMana, currentMana, random, maxDefense)
        {            
            this.skills = skills;            
            this.myJob = job;            
        }
        public static void ShowStatus(Character player)    
        {
        Console.WriteLine($"Name: {player.Name}");
        Console.WriteLine($"Class: {player.Job}");
        Console.WriteLine($"HP: {player.CurrentHp}/{player.MaxHp}");
        Console.WriteLine($"Mana: {player.CurrentMana}/{player.MaxMana}");
        Console.WriteLine($"Skills {player.Skill[0]}, {player.Skill[1]}, {player.Skill[2]}");
        }
    }


}