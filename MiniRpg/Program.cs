using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using MiniRpg.Entity;

namespace MiniRpg;

public class Program
{
    public static void Main()
    {

        Console.WriteLine("==========================");
        Console.WriteLine("TALE OF THE CHAOS MAGE");
        Console.WriteLine("==========================");
        Console.WriteLine("Create you Character:");
        CharacterCreation Player1 = new CharacterCreation();
        Character player = Player1.CreateCharacter();

        Console.WriteLine($"NickName: {player.Name}");
        Console.WriteLine($"Class: {player.Job}");
        Console.WriteLine($"HP: {player.CurrentHp}/{player.MaxHp}");
        Console.WriteLine($"Mana: {player.CurrentMana}/{player.MaxMana}");



    }

}


