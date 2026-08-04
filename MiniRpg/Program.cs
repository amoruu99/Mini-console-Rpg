using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using MiniRpg.Asset;
using MiniRpg.DataFlow;
using MiniRpg.Entity;

namespace MiniRpg;

public class Program
{
    public static void Main()
    {

        Console.WriteLine("==========================");
        Console.WriteLine("Welcome to the TALE OF THE CHAOS MAGE");
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();

        bool gameRunning = true;
    
        while (gameRunning)
        {
            
        MainMenuManager mainMenu = new MainMenuManager();
        mainMenu.MainMenu();
        Console.ReadKey();
        Console.Clear();
        Character character = mainMenu.player;
        character.ShowStatus();
        

        GameTime gameTime = new GameTime();
        gameTime.Prolog();
        break;        
        

        }


        






    }

}


