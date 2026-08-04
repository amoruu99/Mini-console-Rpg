using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniRpg.Entity;

namespace MiniRpg.Asset
{
    public class MainMenuManager
    {
        private Character player = null;

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
                Console.WriteLine("Create you Character:");
                CharacterCreation Creator = new CharacterCreation();
                player = Creator.CreateCharacter();
                player.ShowStatus();
                break;

                case "2":
                Console.WriteLine("Coming sooon");
                Console.Clear();
                MainMenu();
                break;

                case "3":
                Console.WriteLine("Are you sure?\n1. Yes\n2. No");
                switch(Console.ReadLine())
                    {
                        case "1":
                        Environment.Exit(0);
                        break;

                        case "2":
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