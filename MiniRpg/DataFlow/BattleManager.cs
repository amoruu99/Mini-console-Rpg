using MiniRpg.Asset;
using MiniRpg.DataFlow;
using MiniRpg.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace MiniRpg.DataFlow
{
    public class BattleManager
    {
        internal Character? player = MainMenu._instance.player;
        internal Monster? monster = Monster.CreateMonster();
        
        internal void BattleStart(Entity.Entity attacker, Entity.Entity target)
        {
            
            if (attacker is Character)
            {
                player = (Character) attacker;
                monster = (Monster)target;

            }
        }
        internal int Critical(int damage)
        {
            int criticalDamage = damage * 2;            
            return criticalDamage;
        }

        internal void Attack()
        {
            BattleStart(player, monster);
            if (player is Character)
            {
                int damage = player.Damage;
                int randomNumber = new Random().Next(1, 11);
                if (randomNumber <= 3)
                {
                    Console.WriteLine($"{attacker.Name} Tried to Attack but Missed");
                }
                else if (randomNumber <= 8)
                {
                    player.CurrentHp -= damage;
                    Console.WriteLine($"{player.Name} attack {monster.Name} for {damage} damage");
                }
                else
                {
                    Critical(damage);
                    player.CurrentHp -= damage;
                    Console.WriteLine($"{player.Name} Commit a Critical Hit. dealing {damage} damage");
                }
            }
        }
        
        internal void Turn()
        {
            bool isPlayer = false;
            do
            {
            Action action = new Action();
            action.BattleMenu();
            }while (isPlayer == false);
        }
    }

    internal class Action
    {
        public void BattleMenu()
        {            
            bool hasAttacked = false;            
            while (hasAttacked == false)
            {
                Console.Clear();
                Console.WriteLine("Choose Action: ");
                Console.WriteLine("======================");
                Console.WriteLine("1. Attack\t\t3. Item");
                Console.WriteLine("2. Skills\t\t4. Run");
                Console.WriteLine("======================");
                var result = Console.ReadLine();
                switch (result)
                {
                    case "1":                        
                        BattleManager.Attack(MainMenu.Instance.player, BattleManager.monster);
                        Console.WriteLine("Press any key to end your turn");
                        hasAttacked = true;
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    default:
                        Console.WriteLine("Skipped 1 Turn");
                        hasAttacked = true;
                        break;
                }
            }
        }
    }
}

/*
BattleManager
│
├── Player
│
├── Monster
│
├── BattleStart()
│   └── "A wild Goblin/Orc appeared!"
│
├── Turn()
│
├── Attack()
│   └── RNG 1-10
│       ├── 1-3  → Miss
│       ├── 4-8  → Basic Attack
│       └── 9-10 → Critical ×2
│
├── Item()
│
├── Skill()
│
├── Flee()
│
└── CheckBattleState()
    └── Check CurrentHp
*/