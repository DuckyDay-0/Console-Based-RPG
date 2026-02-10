using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.UI
{
    internal static class GameMessages
    {
        public static List<string> NotEnoughStrenghtMsgs = new List<string>
        {
            "This place is too far to reach and you are too weak to get there!",
            "You are too tired to get there!",
            "Odin is not ready to take you yet! Try again tomorrow!",
            "Try to get a hot soup first and try again!",
            "You are too weak to get there!"
        };

        public static List<string> EnoughStenghtMsgs = new List<string>
        {
            "Yes, now that's a spirit!",
            "It was hard ,but you've made it!",
            "You've pushed trough the pain...",
            "Hope it was worth the stenght..."
        };

        public static List<string> FarmingMaterialSuccessful = new List<string>
        {
            "Ah, yes! That was a good one!",
            "O well, great catch!",
            "Use it wisely...",
            "Hope it was worth the hassle..."
        };
    }
}
