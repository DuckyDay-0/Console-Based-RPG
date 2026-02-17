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

        public static void Farm(Player player, Material material)
        {
            Console.Clear();
            int strenghtCost = random.Next(5, 20);

            if (player.TotalStrenght < strenghtCost)
            {
                string rndNotEnoughStrenghtMsg = MessageHelper.MsgRand(GameMessages.NotEnoughStrenghtMsgs);
                Console.WriteLine(rndNotEnoughStrenghtMsg);
                player.ReduceHealth(strenghtCost / 2);
                Console.WriteLine($"Since you had no energy {strenghtCost / 2} was taken from your health.");
                Console.WriteLine("Click any button to continue.");
                Console.ReadKey();
                return;
            }

            player.ReduceStrenght(strenghtCost);
            string rndMsg = MessageHelper.MsgRand(GameMessages.EnoughStenghtMsgs);
            Console.WriteLine($"{rndMsg}\nYou've lost {strenghtCost} of your strenght.");

            int amount = random.Next(0, 5);

            if (amount == 0)
            {
                Console.WriteLine("And, you get nothing this time...");
                Console.ReadKey();
                return;
            }

            Material farmedMaterial = new Material
            (
                material.Name,
                material.Description,
                amount
            );

            player.AddOneItem(farmedMaterial);
            string rndMaterialMsg = MessageHelper.MsgRand(GameMessages.FarmingMaterialSuccessful);
            Console.WriteLine($"{rndMaterialMsg}\n{amount} {material.Name} has been added to your inventory.");
            Console.WriteLine("Press any button to continue.");
            Console.ReadKey();
        }


    }
}
