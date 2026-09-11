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

        /*Console.WriteLine("======================================");
        Console.WriteLine("Welcome to the TALE OF THE CHAOS MAGE");
        Console.WriteLine("======================================");
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();*/

        bool gameRunning = true;
    
        while (gameRunning)
        {            
        MainMenu mainMenu = new MainMenu();
        mainMenu.Menu();
        Console.ReadKey();
        Console.Clear();
        
        Character player = mainMenu.player;
        Character.ShowStatus(player);
        
        /*GameTime gameTime = new GameTime();
        gameTime.Prolog();*/
        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
        
        BattleManager battle = new BattleManager(mainMenu.player);
        battle.Encounter();

        }
        /*MainMenu mainMenu = new MainMenu();
        mainMenu.Menu();   */             
    }

}


