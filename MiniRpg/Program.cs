using System;
using MiniRpg.Asset;
using MiniRpg.DataFlow;
using MiniRpg.Entity;

namespace MiniRpg;

public class Program
{
    public static void Main()
    {
        /*bool gameRunning = true;
    
        while (gameRunning)
        {            
        MainMenu mainMenu = new MainMenu();
        mainMenu.Menu();
        Console.ReadKey();
        Console.Clear();
        
        Character player = mainMenu.player;
        Character.ShowStatus(player);
        
        
        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
        
        BattleManager battle = new BattleManager(player);
        battle.Encounter();
        }*/
        GameTime gameTime = new GameTime();
        gameTime.Prolog();
    }


}


