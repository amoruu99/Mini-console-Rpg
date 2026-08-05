using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniRpg.Entity;
using MiniRpg.Asset;
using System.Threading.Tasks.Dataflow;

namespace MiniRpg.DataFlow
{
    public class BattleManager
    {
        Monster monster = new Monster();
        public int CriticalDamage()
        {
            Character character = MainMenu.Instance.player;
            int criticalDamage = character.MaxDamage *2;
            return criticalDamage;
        }

        public int Damage()
        {
            Character character = MainMenu.Instance.player;
            int damage = character.Random.Next(character.MinDamage, character.MaxDamage) * (monster.MaxDefense / 100);
            return damage;
        }

        public void Battle()
        {
            bool isDead = false;
            while(isDead == false)
            {
                if (MainMenu.Instance.player.MaxHp == 0)
                {
                    Console.WriteLine("You are Died, going back to Main Menu");
                    Console.ReadLine();
                    Console.Clear();
                    isDead = true;
                    MainMenu.Instance.Menu();
                }
                else if (monster.MaxHp == 0)
                {
                    Console.WriteLine($"You have Slain the {monster.Name}");
                    isDead = true;

                    
                }
            }
        }


        public void Attack()
        {
            Entity.Monster monster = new Entity.Monster();
            monster.StatusGoblin();

            MainMenu.Instance.player.CurrentHp -= Damage();
            monster.MaxHp -= Damage();
        }
        public void Turn()
        {
            Asset.Action action = new Asset.Action();
            action.BattleMenu();
            Battle();
        }
    }
}