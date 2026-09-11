using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniRpg.Entity
{
    internal class CharacterCreation
    {
    private string? name;
    private int damage;
    private int maxHp;
    private int currentHp;
    private int maxMana;
    private int currentMana;
    private Random random = new Random();
    private int maxDefense;
    private string[] jobs = { "Tank", "Mage", "DPS" };
    private string[] skills = new string[3];
    private string? myJob;    
    
    public Character CreateCharacter()
        {
            bool charCreated = false;
            string? characterName;
            string? jobSelection; 

            Console.WriteLine("Who are you young Adventurer?");
            Console.WriteLine("");

            characterName = Console.ReadLine();
            if (characterName == null)
            {
                Console.WriteLine("Invalid Name");
            }
            else
            {
                name = characterName;
            }
            while (charCreated != true)
            {
                Console.WriteLine($"and you are a?");
                Console.WriteLine($"1. {jobs[0]}, using High Defense dan durability. Lacks of mana");
                Console.WriteLine($"2. {jobs[1]} High magical power usage, bigger mana but Low at defense and Health");
                Console.WriteLine($"3. {jobs[2]} Combination high Damage and defense");

                jobSelection = Console.ReadLine();
                if(jobSelection != null)
                {
                    switch (jobSelection)
                    {
                        case "1": // Tank Class selection
                            Console.Clear();
                            maxHp = 500; // interval global
                            maxMana = 75; // perhitungan 15% dari HP Tank
                            maxDefense = 250; // perhitngan 50% dari HP Tank
                            damage = random.Next(50, 101);
                            skills = ["Divine Protection", "Shield Bash", "Shield Charge"];
                            charCreated = true;
                            myJob = jobs[0];
                            break;

                        case "2": // Mage Class selection
                            Console.Clear();
                            maxHp = 125; // interval
                            maxMana = 1000; // perhitungan 200 persen dari HP Tank
                            maxDefense = 65; // perhitngan 50% dari HP Mage
                            damage = random.Next(100, 201);
                            skills = ["Fire Bolt", "Chain Lighting", "Fireball"];
                            charCreated = true;
                            myJob = jobs[1];
                            break;

                        case "3": // DPS Class Selection
                            Console.Clear();
                            maxHp = 250; // 50% of tank HP
                            maxMana = 250; // same as Max HP
                            maxDefense = 120; // 50% of tank Defense
                            damage = random.Next(200, 251);
                            skills = ["Assasinate","Sword Slash", "Flash Step"];
                            charCreated = true;
                            myJob = jobs[2];
                            break;

                        default:
                            Console.WriteLine("Choose your Class, or do you have a second though to be an adventurer?");
                            break;
                    }                     
                }
            }
            return new Character(name, damage, maxHp, currentHp, maxMana, currentMana, random, maxDefense, myJob, skills);   
        }

    }
}