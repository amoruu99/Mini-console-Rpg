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
        public int CriticalDamage()
        {
            Character character = MainMenuManager.Instance.player;
            int criticalDamage = character.MaxDamage *2;
            return criticalDamage;
        }

        public int Damage()
        {
            Monster monster = new Monster();
            Character character = MainMenuManager.Instance.player;
            int damage = character.Random.Next(character.MinDamage, character.MaxDamage) * (monster.MaxDefense / 100);
            return damage;
        }

        public void Battle()
        {
            isDead
            while
        }
    }
}