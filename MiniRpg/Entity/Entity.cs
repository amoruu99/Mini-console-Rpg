using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using MiniRpg.Entity;
using MiniRpg.Asset;
using System.ComponentModel.DataAnnotations;

namespace MiniRpg.Entity
{
    internal abstract class Entity
    {
        [Required]
        private string name;
        private int damage;
        private int maxHp;
        private int currentHp;
        private int maxMana;
        private int currentMana;
        private Random random;
        private int maxDefense;        

        
        public string Name { get { return name; } set { name = value; } }
        public int Damage { get { return damage; } set { damage = value; } }
        public int MaxHp { get { return maxHp; } set { maxHp = value; } }
        public int CurrentHp { get { return currentHp; } set { currentHp = value; } }
        public int MaxMana { get { return maxMana; } set { maxMana = value; } }
        public int CurrentMana { get { return currentMana; } set { currentMana = value; } }
        public Random Random { get { return random; } set { random = value; } }
        public int MaxDefense { get { return maxDefense; } set { maxDefense = value; } }

        public Entity(string name, int damage, int maxHp, int currentHp, int maxMana, int currentMana, Random random, int maxDefense)
        {
            this.Name = name;
            this.Damage = damage;
            this.MaxHp = maxHp;
            this.CurrentHp = maxHp;
            this.MaxMana = maxMana;
            this.CurrentMana = maxMana;
            this.Random = random;
            this.MaxDefense = maxDefense;
        }
    }
}