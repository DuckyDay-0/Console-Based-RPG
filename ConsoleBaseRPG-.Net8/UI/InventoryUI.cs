using Console_Based_RPG.Characters;
using Console_Based_RPG.Core;
using Console_Based_RPG.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.UI
{
    internal class InventoryUI
    {


        public static int InventoryNavigatorUI(Player player)
        {
            Console.WriteLine("----Inventory----");
            player.Inventory.ShowInventory();
            Console.WriteLine("-----------------");
            Console.WriteLine("");
            Console.WriteLine("1.Show Item Info");
            Console.WriteLine("2.Equip Item");
            Console.WriteLine("3.Crafting Table");
            Console.WriteLine("4.Remove Item");
            Console.WriteLine("0: Go Back");

            return StartingMenu.GetValidData(0, 4);
        }
        public static void InventoryNavigator(Player player)
        {

            int choice = InventoryNavigatorUI(player);
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    //To do show
                    break;

                case 2:
                    Console.Clear();
                    EquipItemUI(player);
                    break;

                case 3:
                    Console.Clear();
                    //CraftSystemUI.HandleCraftSystemUI();
                    CraftSystemUI.HandleCraftUI(player);
                    break;

                case 4:
                    Console.Clear();
                    RemoveItemUI(player);
                    break;
                case 0:
                    break;
            }
        }


        public static void RemoveItemUI(Player player)
        {
            Console.Clear();
            player.Inventory.ShowInventory();
            Console.WriteLine("Select which item you want to remove.");
            Console.WriteLine("Press 0 to go cancel.");


            if (player.Inventory.Items.Count == 0)
            {
                Console.ReadKey();
                return;
            }
            int choice = Inventory.SelectItem(player);

            if (choice == 0)
            {
                return;
            }


            Item item = player.Inventory.Items[choice - 1];
            player.Inventory.RemoveItemsFromInventory(item, player);
            InventoryNavigator(player);
        }

        public static void EquipItemUI(Player player)
        {
            Console.Clear();
            player.Inventory.ShowInventory();
            Console.WriteLine("Select the item you want to equip.");
            Console.WriteLine("Press 0 to go cancel.");

            if (player.Inventory.Items.Count == 0)
            {
                Console.ReadKey();
                return;
            }

            int choice = Inventory.SelectItem(player);

            if (choice == 0)
            {
                return;
            }

            Item item = player.Inventory.Items[choice - 1];
            player.EquipItem(item, out string message);
            InventoryNavigator(player);
        }


        
    }
}
