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
        private int maxDamage;
        private int maxHp;
        private int maxMana;
        private Random random;
        private int maxDefense;
        public virtual void Said()
        {
            Console.WriteLine("Rumbling Sounds heard");
        }

        public string Name { get { return name; } }
        public int MaxDamage { get { return maxDamage; } }
        public int MaxHp { get { return maxHp; } set { maxHp = value; } }
        public int MaxMana { get { return maxMana; } set { maxMana = value; } }
        public int MaxDefense { get {return maxDefense;}}
        public Random Random { get { return random;} }



        public class Goblin : Monster
        {
            public override void Said()
            {
                Console.WriteLine("Kekekeke!!, new prey new prey");
            }
            public Goblin(string name, int maxDamage, int maxHp, int maxMana, Random random, int maxDefense)
            {
                this.name = name;
                this.maxDamage = maxDamage;
                this.maxHp = maxHp;
                this.maxMana = maxMana;
                this.maxDefense = maxDefense;                
            }
           
        }
        public void StatusGoblin()
        {
            name = "Goblin Alas";
            maxDamage = random.Next(25, 36);
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

            public Orc(string name, int maxDamage, int maxHp, int maxMana, Random random, int maxDefense)
            {
                this.name = name;
                this.maxDamage = maxDamage;
                this.maxHp = maxHp;
                this.maxMana = maxMana;
                this.maxDefense = maxDefense;
            }

            public void StatusOrc()
            {
                name = "Orc";
                maxDamage = random.Next(35, 51);
                maxHp = 300;
                maxMana = 0;
                maxDefense = 50;
            }
        }
    }
}