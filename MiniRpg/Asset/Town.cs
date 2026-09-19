using System;
using System.Collections.Generic;
using System.Text;
using MiniRpg.DataFlow;

namespace MiniRpg.Asset
{
    internal class Town : BaseLocation
    {
        private string[] locations = { "Guild", "Blacksmith", "West Point Gate" };        


        public string[] Location { get { return locations; } }
        public Town(string name, string[] desc, string[] location)
        :base (name, desc)
        {
            this.locations = location;
        }

        public void Lumina()
        {
            // The Town of Lumina (Luminous and peaceful)
            Name = "Town of Lumina";

            Description = new string[]
                {
                "[ Area: The Town of Lumina ]",
                "",
                "The town of Lumina lives up to its name. Soft, glowing crystals float",
                "above the cobblestone streets, pushing back the dark wilderness you just left.",
                "",
                "It is not a noisy city, but a quiet sanctuary. Other lone wanderers and",
                "mercenaries stand near the alleyways, keeping to themselves.",
                "",
                "Near the center of the town stands the Adventurer's Guild. Its wooden doors",
                "are wide open, offering a fresh start to anyone willing to risk their life.",
                "",
                "[ Points of Interest ]",
                "[1] The Adventurer's Guild (Register / Take Quests)",
                "[2] The Local Blacksmith (Buy / Sell Equipment)",                
                "[3] Go To West Point Gate (Gathering or Combat)"
            };

            foreach (string lumina in Description)
            {
                Console.WriteLine(lumina);
                Thread.Sleep(1000);
            }
            Console.ReadKey();            
        }
    }
}

