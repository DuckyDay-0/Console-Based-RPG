using ConsoleBaseRPG_.Net8.Entity;
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



        public static CraftReceip ChargedSwampCore = new CraftReceip
        (
            "Charged Swamp Core",
            () => new Material("Charged Swamp Core", "Craftable Material", 1),
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
            () => new Material("Living Vine Core", "Craftable Material", 1),
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
            () => new Material("Ancient Alloy Plate", "Craftable Material", 1),
            new Dictionary<string, int>
            {
                {"Pine Wood", 8},
                {"Troll Hide Armor", 4}
            }
        );

        public static CraftReceip LightHealthPotion = new CraftReceip
        (
            "Light Health Potion",
            () => new HealthPotion("Light Health Potion", 15, 1),
            new Dictionary<string, int>
            {               
                {"Sturling Core", 2},
                {"Copper", 2}
            }
        );

        public static CraftReceip MidHealthPotion = new CraftReceip
        (
            "Mid Health Potion",
            () => new Material("Mid Health Potion", "Craftable Item", 1),
            new Dictionary<string, int>
            {
                {"Sturling Core", 4},
                {"Copper", 4}
            }
        );

        public static CraftReceip HighHealthPotion = new CraftReceip
        (
            "High Health Potion",
            () => new Material("High Health Potion", "Craftable Item", 1),
            new Dictionary<string, int>
            {
               {"Sturling Core", 8},
               {"Copper", 8}
            }
        );

        public static CraftReceip StrenghtPotion = new CraftReceip
        (
            "Strenght Potion",
            () => new Material("Strenght Potion", "Craftable Item", 1),
            new Dictionary<string, int>
            {
                       {"Sturling Core", 2},
                       {"Copper", 2}
            }
        );

        public static CraftReceip ArtisanTable = new CraftReceip
        (
            "Artisan Table",
            () => new Material("Artisan Table", "Craftable Item", 1),
            new Dictionary<string, int>
            {
                       {"Dragon Tears", 2},
                       {"Pine Wood", 8}
            }
        );
    }
}
