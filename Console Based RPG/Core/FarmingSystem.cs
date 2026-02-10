using Console_Based_RPG.Characters;
using Console_Based_RPG.Items;
using Console_Based_RPG.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.Core
{
    internal class FarmingSystem
    {
        private static Random random = new Random();

        public static void Farm(Player player, Item material)
        {
            Console.Clear();
            int strenghtCost = random.Next(5, 17);

            if (player.TotalStrenght < strenghtCost)
            {
                MessageHelper.MsgRand(GameMessages.NotEnoughStrenghtMsgs);
                Console.ReadKey();
            }

            player.ConsumeStrenght(strenghtCost);
            string rndMsg = MessageHelper.MsgRand(GameMessages.EnoughStenghtMsgs);
            Console.WriteLine($"{rndMsg}\nYou've lost {strenghtCost} of your strenght.");

            int amount = random.Next(0, 5);

            if (amount == 0)
            {
                Console.WriteLine("And, you get nothing this time...");
                Console.ReadKey();
                return;
            }
            player.AddOneItem(material);
            string rndMaterialMsg = MessageHelper.MsgRand(GameMessages.FarmingMaterialSuccessful);
            Console.WriteLine($"{rndMaterialMsg}\n{amount} {material.Name} has been added to your inventory.");
            Console.WriteLine("Press any button to continue.");
            Console.ReadKey();
        }


    }
}
