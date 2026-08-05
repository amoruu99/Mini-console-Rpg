using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace MiniRpg.Entity
{
    public class Monster
    {
        private string name;
        private int damage;
        private int maxHp;
        private int currentHp;
        private int maxMana;
        private int currentMana;
        private Random random;
        private int maxDefense;
        public virtual void Said()
        {
            Console.WriteLine("Rumbling Sounds heard");
        }

        public string Name { get { return name; } }
        public int Damage { get { return damage; } }
        public int MaxHp { get { return maxHp; } }
        public int CurrentHp {get{return currentHp;} set {currentHp = value;}}
        public int MaxMana { get { return maxMana; } }
        public int CurrentMana {get{return currentMana;} set {currentMana = value;}}
        public int MaxDefense { get {return maxDefense;}}
        public Random Random { get { return random;} }



        public class Goblin : Monster
        {
            public override void Said()
            {
                Console.WriteLine("Kekekeke!!, new prey new prey");
            }
            public Goblin(string name, int damage, int maxHp, int currentHp, int maxMana,int currentMana, Random random, int maxDefense)
            {
                this.name = name;
                this.damage = damage;
                this.maxHp = maxHp;
                this.currentHp = currentHp;
                this.maxMana = maxMana;
                this.currentMana = currentMana;
                this.maxDefense = maxDefense;                
            }
           
        }
        public void StatusGoblin()
        {
            name = "Goblin Alas";
            damage = random.Next(25, 36);
            maxHp = 150;
            maxMana = 20;
            maxDefense = 15;
        }  

        public class Orc : Monster
        {
            public override void Said()
            {
                Console.WriteLine("Grok Grok, did you smell something?");
            }

            public Orc(string name, int damage, int maxHp, int currentHp, int maxMana,int currentMana, Random random, int maxDefense)
            {
                this.name = name;
                this.damage = damage;
                this.maxHp = maxHp;
                this.currentHp = currentHp;
                this.maxMana = maxMana;
                this.currentMana = currentMana;
                this.maxDefense = maxDefense;  
            }

            public void StatusOrc()
            {
                name = "Orc";
                damage = random.Next(35, 51);
                maxHp = 300;
                maxMana = 0;
                maxDefense = 50;
            }
        }
    }
}