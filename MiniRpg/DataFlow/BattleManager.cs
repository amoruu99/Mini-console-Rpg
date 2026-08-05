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
        public int PlayerCritical(Character player)
        {
            int criticalDamage = player.Damage * 2;
            Console.WriteLine($"{player.Name} Commit a Critical Hit");
            return criticalDamage;
        }
        public int MonsterCritical(Monster monster)
        {
            int criticalDamage = monster.Damage * 2;
            Console.WriteLine($"{monster.Name} Commit a Critical Hit");
            return criticalDamage;
        }
        public void CommitBattle(Character player, Monster monster)
        {
            
        }

        public void PlayerAttack(Character player, Monster monster)
        {
            
        }
        public void MonsterAttack(Monster moster, Character player)
        {
            
        }
        
        public void Turn(Character player, Monster monster)
        {
            bool isPlayer = false;
            do
            {
            Asset.Action action = new Asset.Action();
            action.BattleMenu();
            }while (isPlayer == true);
        }
    }
}