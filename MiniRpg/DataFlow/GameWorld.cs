using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniRpg.Entity;
using MiniRpg.Asset;

namespace MiniRpg.DataFlow
{
    internal class GameTime
    {
        public void Prolog()
        {
            string[] prologLines =
            {
                "You wake up beneath a strange sky, with no memory of how you arrived.",
                "The world around you is unfamiliar. Even the air feels different.",
                "You soon realize that this is not the world you once knew.",
                "You have no answers, no allies, and no way back home.",
                "But a nearby town offers one thing you desperately need: a chance to start over.",
                "You decide to become an adventurer. Perhaps, " +
                "somewhere along the way, you will discover who you truly are.",
                "You take a deep breath, and walk towards the closeby town",
                "You enter the Town of Lumina"
            };

            foreach (string lines in prologLines)
            {
                foreach (char c in lines)
                {
                    Console.Write(c);
                    Thread.Sleep(50);                    
                }                
                Console.WriteLine();
                Console.ReadKey();
                Thread.Sleep(1500);
            }
        }
    }

    internal class World
    {
    
        public void ForestEnterance()
        {
            // Forest 1: Beginner Area (For Entry Level)
            string name = "Whishpering Woods Forest";

            string[] whisperingWoodsDesc = 
            {
                "[ Area: The Whispering Woods ]",
                "",
                "Sunlight barely pierces through the thick green canopy above.",
                "The wind rustles the leaves, making a sound like distant, hushed voices.",
                "",
                "Small tracks in the mud suggest that weak monsters, like slimes and",
                "stray goblins, roam this area. It is a good place for a rookie to train.",
                "",
                "[ Actions ]",
                "[1] Search for weak monsters (Fight)",
                "[2] Forage for herbs (Gather)",
                "[3] Return to Lumina"
            };
            foreach (string whisperingWood in whisperingWoodsDesc)
            {
                Console.WriteLine(whisperingWood);
                Thread.Sleep(1000);
            }
            Console.ReadKey();

        // Forest 2: Intermediate Area (Darker and More Dangerous)
            string[] ashenThicketDesc = 
            {
                "[ Area: The Ashen Thicket ]",
                "",
                "The air here is thick and smells of burnt wood. The trees are dead,",
                "their twisted branches reaching out like skeletal hands.",
                "",
                "Gray ash falls from the sky like snow. You can hear the low, deep growls",
                "of shadow wolves circling in the mist. You should not let your guard down.",
                "",
                "[ Actions ]",
                "[1] Hunt the shadow wolves (Fight)",
                "[2] Search the ruined campsite (Explore)",
                "[3] Retreat to safety"
            };
            foreach (string ashenThicket in ashenThicketDesc)
            {
                Console.WriteLine(ashenThicket);
                Thread.Sleep(1000);
            }
            Console.ReadKey();
        }

        public void DungeonEnterance()
        {
            // Dungeon 1: Beginner Crypt (Clasic Dungeon)
            string[] sunkenCryptDesc = 
            {
                "[ Area: The Sunken Crypt - Floor 1 ]",
                "",
                "The heavy stone doors slide shut behind you. The air is cold, damp,",
                "and smells of ancient decay. Water drips slowly from the ceiling.",
                "",
                "Torches flicker with pale blue fire along the walls, revealing the",
                "shuffling shadows of the undead waking up from their slumber.",
                "",
                "[ Actions ]",
                "[1] Advance into the darkness (Fight)",
                "[2] Inspect the strange altar (Explore)",
                "[3] Escape back to the surface"
            };

            // Dungeon 2: Hard Dungeon (Magical and deadly)
            string[] obsidianHollowDesc = 
            {
                "[ Area: The Obsidian Hollow - Depths ]",
                "",
                "The walls of this deep cavern are made of jagged, black glass.",
                "Pulsing red magic flows through the cracks in the stone like blood.",
                "",
                "This place is unnatural. The corrupted crystal golems that guard this",
                "area will crush anyone who is unprepared. Tread very carefully.",
                "",
                "[ Actions ]",
                "[1] Challenge the Crystal Golem (Boss Fight)",
                "[2] Mine for rare magical shards (Gather)",
                "[3] Run away before it sees you"
            };
        }
    }
}