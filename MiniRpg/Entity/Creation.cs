using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniRpg.Entity
{
    internal class CharacterCreation
    {
    private int maxDamage;
    private int minDamage;
    private int maxHp;
    private int maxMana;
    private string? name;
    private string[] jobs = { "Tank", "Mage", "DPS" };
    private string[] skills = new string[3];
    private int maxDefense;
    private string myJob;
    private Random random;

    
    public Character CreateCharacter()
        {
            bool charCreated = false;
            string? characterName;
            string? jobSelection; 

            Console.WriteLine("Who are you young Adventurer?");
            Console.WriteLine("");

            characterName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(characterName))
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
                            minDamage = 50;
                            maxDamage = 100;
                            skills = ["Divine Protection", "Shield Bash", "Shield Charge"];
                            charCreated = true;
                            myJob = jobs[0];
                            break;

                        case "2": // Mage Class selection
                            Console.Clear();
                            maxHp = 125; // interval
                            maxMana = 1000; // perhitungan 200 persen dari HP Tank
                            maxDefense = 65; // perhitngan 50% dari HP Mage
                            minDamage = 100;
                            maxDamage = 200;
                            skills = ["Fire Bolt", "Chain Lighting", "Fireball"];
                            charCreated = true;
                            myJob = jobs[1];
                            break;

                        case "3": // DPS Class Selection
                            Console.Clear();
                            maxHp = 250; // 50% of tank HP
                            maxMana = 250; // same as Max HP
                            maxDefense = 120; // 50% of tank Defense
                            minDamage = 200;
                            maxDamage = 250;
                            skills = ["Assasinate","Sword Slash", "Flash Step"];
                            charCreated = true;
                            myJob = jobs[2];
                            break;

                        default:
                            Console.WriteLine("Choose your Class, or do you have a second though to be a adventurer?");
                            break;
                    }                     
                }
            }
            return new Character(maxHp, maxMana, maxDefense, minDamage, maxDamage, skills, name, myJob, random);   
        }

    }
}