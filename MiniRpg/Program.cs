using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using MiniRpg.Entity;
using MiniRpg.Asset;

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

        MainMenuManager mainMenu = new MainMenuManager();
        mainMenu.MainMenu();
        






    }

}


