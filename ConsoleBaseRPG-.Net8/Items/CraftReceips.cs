using ConsoleBaseRPG_.Net8.Entity;
using ConsoleBaseRPG_.Net8.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.Items
{
    internal class CraftReceips
    {
        //Armors
        public static CraftReceip IronArmor = new CraftReceip
        (
            "Iron Armor",
            () => Materials.materials["iron armor"],
            new Dictionary<string, int>
            {
                {"Iron", 6},
                {"Rope", 4}
            }
        );
        public static CraftReceip RootArmor = new CraftReceip
        (
            "Root Armor",
            () => Materials.materials["root armor"],
            new Dictionary<string, int>
            {
                {"Muddy Scrap", 6},
                {"Entrails", 4},
                {"Living Vine Core",1}
            }
        );

        public static CraftReceip WolfSkinArmor = new CraftReceip
        (
            "Wolf Skin Armor",
            () => Materials.materials["wolf skin armor"],
            new Dictionary<string, int>
            {
                {"Iron", 2},
                {"Wolf Skin", 4},
                {"Rope", 1}
            }
        );

        public static CraftReceip FenrisDragonArmor = new CraftReceip
        (
            "Fenris Dragon Armor",
            () => Materials.materials["fenris dragon armor"],
            new Dictionary<string, int>
            {
                {"Iron", 5},
                {"Rope", 3},
                {"Dragon Skin", 2}
            }
        );

      
        //Weapons
        public static CraftReceip IronSword = new CraftReceip
        (
            "Iron Sword",
            () => Materials.materials["iron sword"],
            new Dictionary<string, int>
            {
                {"Iron", 5},
                {"Pine Wood", 5}
            }
        );

        public static CraftReceip ChargedSwampCore = new CraftReceip
        (
            "Charged Swamp Core",
            () => Materials.materials["charged swamp core"],
            new Dictionary<string, int>
            {
                {"Sturling Core", 5},
                {"Copper", 8},
                {"Living Vine Core", 1},
                {"Ancient Alloy Plate", 1}
            }
        );

        public static CraftReceip LivingVineCore = new CraftReceip
        (
            "Living VineCore",
            () => Materials.materials["living vine core"],
            new Dictionary<string, int>
            {
                {"Sturling Core", 9},
                {"Copper", 10},
                {"Ancient Alloy Plate", 1}
            }
        );

        public static CraftReceip AncientAlloyPlate = new CraftReceip
        (
            "Ancient Alloy Plate",
            () => Materials.materials["ancient alloy plate"],
            new Dictionary<string, int>
            {
                {"Pine Wood", 8},
                {"Troll Hide Armor", 4}
            }
        );

        //Potions 
        public static CraftReceip LightHealthPotion = new CraftReceip
        (
            "Light Health Potion",
            () => HealthPotions.healthPotions["light health potion"],
            new Dictionary<string, int>
            {               
                {"Sturling Core", 2},
                {"Copper", 2}
            }
        );

        public static CraftReceip MidHealthPotion = new CraftReceip
        (
            "Mid Health Potion",
            () => HealthPotions.healthPotions["mid health potion"],
            new Dictionary<string, int>
            {
                {"Sturling Core", 4},
                {"Copper", 4}
            }
        );

        public static CraftReceip HighHealthPotion = new CraftReceip
        (
            "High Health Potion",
            () => HealthPotions.healthPotions["high health potion"],
            new Dictionary<string, int>
            {
               {"Sturling Core", 8},
               {"Copper", 8}
            }
        );

        public static CraftReceip StrenghtPotion = new CraftReceip
        (
            "Strenght Potion",
            () => StrenghtPotions.strenghtPotions["light strenght potion"],
            new Dictionary<string, int>
            {
               {"Sturling Core", 2},
               {"Copper", 2}
            }
        );
        


    }
}
