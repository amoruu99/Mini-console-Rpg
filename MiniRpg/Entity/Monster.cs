using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace MiniRpg.Entity
{
    internal class Monster : Entity
    {
        public Monster(string name, int damage, int maxHp, int currentHp, int maxMana, int currentMana, Random random, int maxDefense)
        :base(name, damage, maxHp, currentHp, maxMana, currentMana, random, maxDefense)
        {

        }        
        public virtual void Said()
        {
            Console.WriteLine("Rumbling Sounds heard");
        }

        internal static Monster CreateMonster()
        {
            Random random = new Random();
            var monsterType = random.Next(1, 3);
            switch (monsterType)
            {
                case 1:
                    Goblin goblin1 = new Goblin("No Name", 0, 0, 0, 0, 0, random, 0);
                    goblin1.StatusGoblin();
                    goblin1.Said();
                    return goblin1;

                case 2:
                    Orc orc1 = new Orc("No Name", 0, 0, 0, 0, 0, random, 0);
                    orc1.StatusOrc();
                    orc1.Said();
                    return orc1;

                default:
                    throw new Exception("More monster to be updated");
            }            
        }        

        public class Goblin : Monster
        {
            public override void Said()
            {
                Console.WriteLine("Kekekeke!!, new prey new prey");
            }

            public Goblin(string name, int damage, int maxHp, int currentHp, int maxMana, int currentMana, Random random, int maxDefense)
                : base(name, damage, maxHp, currentHp, maxMana, currentMana, random, maxDefense)
            {
                              
            }
            public Monster StatusGoblin()
            {
                Name = "Goblin Alas";
                Damage = Random.Next(25, 36);
                MaxHp = 150;
                MaxMana = 20;
                MaxDefense = 15;
                return new Goblin(Name, Damage, MaxHp, CurrentHp, MaxMana, CurrentMana, Random, MaxDefense);
            }

        }


        public class Orc : Monster
        {
            public override void Said()
            {
                Console.WriteLine("Grok Grok, did you smell something?");
            }

            public Orc(string name, int damage, int maxHp, int currentHp, int maxMana, int currentMana, Random random, int maxDefense)
                : base(name, damage, maxHp, currentHp, maxMana, currentMana, random, maxDefense)
            {
            }

            public Monster StatusOrc()
            {
                Name = "Orc";
                Damage = Random.Next(35, 51);
                MaxHp = 300;
                MaxMana = 0;
                MaxDefense = 50;
                return new Orc(Name, Damage, MaxHp, CurrentHp, MaxMana, CurrentMana, Random, MaxDefense);
            }
        }
    }
}