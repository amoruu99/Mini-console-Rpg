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
        public void ShowStatus()    
        {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Class: {Job}");
        Console.WriteLine($"HP: {CurrentHp}/{MaxHp}");
        Console.WriteLine($"Mana: {CurrentMana}/{MaxMana}");
        Console.WriteLine($"Skills {Skill[0]}, {Skill[1]}, {Skill[2]}");
        }
    }


}