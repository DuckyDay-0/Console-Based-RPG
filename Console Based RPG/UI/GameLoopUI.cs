using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.UI
{
    internal class GameLoopUI
    {
        public static int GameLoopNavigator()
        {
            Console.WriteLine("----What do you do now?----");
            Console.WriteLine("1.Explore");
            Console.WriteLine("2.Inventory");
            Console.WriteLine("3.Stats");
            Console.WriteLine("4.Exit");

            return StartingMenu.GetValidData(1, 4);
        }
    }
}
