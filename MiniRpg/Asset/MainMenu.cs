using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniRpg.Entity;
using MiniRpg.Asset;
using MiniRpg.DataFlow;

namespace MiniRpg.Asset
{
    public class MainMenuManager
    {   
        public static MainMenuManager _instance;
        public static MainMenuManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MainMenuManager();
                }
                return _instance;
            }
        }
        public Character player;

        public void MainMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. Load Game");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Choose wisely");
    
            switch(Console.ReadLine())
            {
                case "1":
                Console.Clear();
                Console.WriteLine("Create you Character:");                
                CharacterCreation Creator = new CharacterCreation();
                player = Creator.CreateCharacter();
                Console.WriteLine($"Good Choice young man, you are now a {player.Job}");
                player.ShowStatus();
                break;

                case "2":
                Console.Clear();
                Console.WriteLine("Coming sooon\nPress any key to continue");
                Console.ReadKey();
                Console.Clear();
                MainMenu();
                break;

                case "3":
                Console.Clear();
                Console.WriteLine("Are you sure?\n1. Yes\n2. No");
                switch(Console.ReadLine())
                    {
                        case "1":
                        Console.Clear();
                        Console.WriteLine("Goodbye!");
                        Environment.Exit(0);
                        break;

                        case "2":
                        Console.Clear();
                        MainMenu();
                        break;
                    }
                break;

                default:
                Console.WriteLine("Choose wisely");
                MainMenu();
                break;
            }
        }
    } 
}