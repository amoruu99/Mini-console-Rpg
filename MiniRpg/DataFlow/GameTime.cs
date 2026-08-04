using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniRpg.Entity;
using MiniRpg.Asset;

namespace MiniRpg.DataFlow
{
    public class GameTime
    {
        public void Prolog()
        {
            string[] prologLines =
            {
                "You awake to the smell of ash and the crackle of untamed magic.",
                "They called your power a curse. An anomaly. A danger to the realm.",
                "They tried to seal you away in the depths, hoping the world would forget.",
                "But the chains are broken now.",
                "The Order has fallen, and the elements weep for a new master.",
                "Embrace the madness within. Your journey begins."
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