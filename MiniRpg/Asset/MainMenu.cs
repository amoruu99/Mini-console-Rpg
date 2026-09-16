using System;
using MiniRpg.Entity;

namespace MiniRpg.Asset
{
    public class MainMenu
    {
        internal Character? player;

        public bool Menu()
        {
            bool isExit = false;
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. Load Game");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Choose wisely");
            int gameChoice = int.Parse(Console.ReadLine());            
            switch (gameChoice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Create you Character:");
                    CharacterCreation Creator = new CharacterCreation();
                    player = Creator.CreateCharacter();
                    Console.WriteLine($"Good Choice young man, you are now a {player.Job}");
                    Character.ShowStatus(player);
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Coming sooon\nPress any key to continue");
                    Console.ReadKey();
                    Console.Clear();                        
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Are you sure?\n1. Yes\n2. No");
                    int exit = int.Parse(Console.ReadLine());
                    switch (exit)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Goodbye!");
                            isExit = true;
                            break;

                        case 2:
                            Console.Clear();                                
                            break;
                    }
                    return isExit;

                default:
                    Console.WriteLine("Choose wisely");                        
                    break;  
            }            
        return isExit;
        }        
    }    
}