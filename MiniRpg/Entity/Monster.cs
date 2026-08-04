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
                this.name = "Goblin Alas";
                this.maxDamage = random.Next(25, 36);
                this.maxHp = 150;
                this.maxMana = 20;
                this.maxDefense = 15;
                
            }
        }

        public class Orc : Monster
        {
            public override void Said()
            {
                Console.WriteLine("Grok Grok, did you smell something?");
            }

            public Orc(string name, int maxDamage, int maxHp, int maxMana, Random random)
            {
                this.name = "Orc";
                this.maxDamage = random.Next(35, 51);
                this.maxHp = 300;
                this.maxMana = 0;
                this.maxDefense = 50;
            }
        }
    }
}