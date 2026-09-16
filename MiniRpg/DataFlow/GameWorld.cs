using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniRpg.Entity;
using MiniRpg.Asset;

namespace MiniRpg.DataFlow
{
    public class GameWorld
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
                "You decide to become an adventurer. Perhaps, somewhere along the way, you will discover who you truly are."
            };

            foreach (string line in prologLines)
            {
                Console.WriteLine(line);
                Thread.Sleep(1500);
                Console.ReadKey();
            }
        }
    }    
}