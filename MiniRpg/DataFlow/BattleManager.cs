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
        internal Character? player = MainMenu._instance?.player;
        internal Monster? monster = Monster.CreateMonster();
        
        internal void BattleStart()
        {            
            Console.WriteLine("A {0} appeared!", monster.Name);
            Console.WriteLine($"Entering the Battle");            
            Console.WriteLine("Do you want to fight? (Y/N)");
            string input = Console.ReadLine();
            if (input.ToUpper() == "Y")
            {
                CheckBattleState(player, monster);
            }
            else
            {
                Console.WriteLine("What a Coward!!");
                Environment.Exit(0);
            }
        }
        internal void Attack(Entity.Entity attacker, Entity.Entity target)
        {
                int damage = attacker.Damage;
                int randomNumber = new Random().Next(1, 11);
                if (randomNumber <= 3)
                {
                    Console.WriteLine($"{attacker.Name} Tried to Attack but Missed");
                }
                else if (randomNumber <= 8)
                {
                    attacker.CurrentHp -= damage;
                    Console.WriteLine($"{attacker.Name} attack {target.Name} for {damage} damage");
                }
                else
                {
                    Critical(damage);
                    attacker.CurrentHp -= damage;
                    Console.WriteLine($"{attacker.Name} Commit a Critical Hit. dealing {damage} damage");
                }
            
        }
        
        internal void PlayerTurn()
        {
            Console.WriteLine("Your turn to attack");
            BattleMenu();
        }

        internal void MonsterTurn()
        {
            Console.WriteLine("Enemy turn to attack");
            Attack(monster, player);
        }
      
        internal void CheckBattleState(Entity.Entity attacker, Entity.Entity target)
        {
            while (attacker.CurrentHp > 0 && target.CurrentHp > 0)
            {
                PlayerTurn();
                if (player.CurrentHp <= 0)
                {
                    Console.WriteLine($"{player.Name} has been defeated!");
                    break;
                }
                MonsterTurn();
                if (monster.CurrentHp <= 0)
                {
                    Console.WriteLine($"{monster.Name} has been annihilated!");
                    break;
                }
            }

        }
        public void BattleMenu()
        {
            bool hasAttacked = false;
            while (hasAttacked != true)
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
                        Attack(player, monster);
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
        internal int Critical(int damage)
        {
            int criticalDamage = damage * 2;
            return criticalDamage;
        }
    }    
}

/*
BattleManager
│
├── BattleStart()
│      └── Battle Loop
│
├── PlayerTurn()
│   └── BattleMenu()
│       ├── Attack()
│       ├── Skill()
│       ├── Item()
│       └── Flee()
│
├── CheckBattleState()
│
├── MonsterTurn()
│   └── Monster Attack
│
└── CheckBattleState()
*/