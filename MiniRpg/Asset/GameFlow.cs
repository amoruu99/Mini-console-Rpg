using MiniRpg.Asset;
using MiniRpg.DataFlow;
using MiniRpg.Entity;

namespace MiniRpg.Asset
{    
    internal class GameFlow
    {        
        bool gameRunning = true;
        public void StartGame()
        {
            while (gameRunning)
            {
                GameTime prolog = new GameTime();
                MainMenu mainMenu = new MainMenu();
                var isExit = mainMenu.Menu();
                if (isExit)
                {
                    gameRunning = false;
                    break;
                }
                Console.ReadKey();
                Console.Clear();

                
                Character player = mainMenu.player;
                Character.ShowStatus(player);
                Console.ReadKey();
                
                prolog.Prolog();
            }
        }
    }
}


/*GameFlow
│
├── MainMenu
│
├── New Game
│   │
│   ├── CharacterCreation
│   │
│   └── Prologue
│       │
│       ├── World asal
│       ├── Isekai
│       └── Dunia baru
│
├── Gameplay
│   │
│   ├── Town
│   ├── Adventurer Guild
│   ├── Quest
│   ├── Exploration
│   └── Encounter
│
└── Battle
    └── BattleManager*/