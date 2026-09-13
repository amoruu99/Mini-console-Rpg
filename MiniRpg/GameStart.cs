using MiniRpg.Asset;
using MiniRpg.DataFlow;
using MiniRpg.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniRpg
{    
    internal class GameStart
    {
        bool gameRunning = true;
        public void StartGame()
        {
            while (gameRunning)
            {
                MainMenu mainMenu = new MainMenu();
                var isExit = mainMenu.Menu();
                if (isExit)
                {
                    gameRunning = false;
                }
                Console.ReadKey();
                Console.Clear();

                Character player = mainMenu.player;
                Character.ShowStatus(player);
                Console.ReadKey();

                BattleManager battle = new BattleManager(player);
                battle.Encounter();
                
            }
        }
    }
}
