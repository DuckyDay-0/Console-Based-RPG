using Console_Based_RPG.Characters;
using Console_Based_RPG.UI;
using ConsoleBaseRPG_.Net8.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.Core
{
    internal class FarmingSystem
    {
        private readonly Random _random;
        public FarmingSystem(Random? random = null)
        { 
            _random = random ?? new Random();
        }

        public bool Farm(Player player, Material material, out string message)
        {
            message = string.Empty;
            int strenghtCost = _random.Next(5, 20);

            if (player.TotalStrenght < strenghtCost)
            {
                string rndNotEnoughStrenghtMsg = MessageHelper.MsgRand(GameMessages.NotEnoughStrenghtMsgs);
                message = rndNotEnoughStrenghtMsg;
                player.ReduceHealth(strenghtCost / 2);
                message = $"Since you had no energy {strenghtCost / 2} was taken from your health.";
                message = "Click any button to continue.";
                return false;
            }

            player.ReduceStrenght(strenghtCost);
            string rndMsg = MessageHelper.MsgRand(GameMessages.EnoughStenghtMsgs);
            message = $"{rndMsg}\nYou've lost {strenghtCost} of your strenght.";

            int amount = _random.Next(0, 5);
            if (amount == 0)
            {
                message = "And, you get nothing this time...";
                return false;
            }

            Material farmedMaterial = new Material
            (
                material.Name,
                material.Description,
                amount
            );

            player.AddOneItem(farmedMaterial);
            string rndMaterialMsg = MessageHelper.MsgRand(GameMessages.FarmingMaterialSuccessful);
            message = $"{rndMaterialMsg}\n{amount} {material.Name} has been added to your inventory.";
            message = "Press any button to continue.";

            return true;
        }


    }
}
