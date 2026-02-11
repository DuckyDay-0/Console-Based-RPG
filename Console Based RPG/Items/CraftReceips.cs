using Console_Based_RPG.Core;
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
                {"Copper", 10}
            }
        );
    }
}
