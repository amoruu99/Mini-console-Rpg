using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using MiniRpg.Entity;
using MiniRpg.Asset;

namespace MiniRpg.Entity
{
    public class Character
    {
        private int currentHp;
        private int currentMana;
        private int damage;
        private int maxHp;
        private int maxMana;
        private string name;
        private string[] jobs = { "Tank", "Mage", "DPS" };
        private string[] skills = new string[3];
        private int maxDefense;
        private string myJob;
        private Random random;


        public string Name { get { return name; } set { name = value; } }
        public string Job { get { return myJob; } }
        public int CurrentHp { get { return currentHp; } set { currentHp = value; } }
        public int CurrentMana {get {return currentMana;} set{currentMana = value;}}
        public string[] Skill { get { return skills;}}
        public int MaxMana { get{return maxMana;}}
        public int MaxHp { get{return maxHp;}}
        public int MaxDefense { get{return maxDefense;}}
        public int Damage { get{return damage;} set{damage = value;}}
        public Random Random { get{return random;}}


        public Character(int maxHp, int maxMana, int maxDefense, int damage, string[] skills, string name, string job, Random random)
        {
            this.maxHp = maxHp;
            this.maxMana = maxMana;
            this.currentHp = maxHp;
            this.currentMana = maxMana;
            this.maxDefense = maxDefense;
            this.damage = damage;
            this.skills = skills;
            this.name = name;
            this.myJob = job;
            this.random = new Random(); 
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