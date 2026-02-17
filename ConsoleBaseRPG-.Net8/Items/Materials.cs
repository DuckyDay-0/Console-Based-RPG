using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.Items
{
    internal class Materials
    {
        public static Dictionary<string, Material> materials = new Dictionary<string, Material>
        {
            {"sturling core", new Material("Sturling Core", "Material")},
            {"pine wood", new Material("Pine Wood", "Material")},
            {"copper", new Material("Copper", "Material")},
            {"ancient bark", new Material("Ancient Bark", "Material")},
            {"mudy scrap", new Material("Mudy Scrap", "Material")},
            {"turnip seeds", new Material("Turnip Seeds", "Material")},
            {"charged swamped core", new Material("Charged Swamp Core", "Swamp Access Key") },
            {"living vine core", new Material("Living Vine Core", "Craftable Material")},
            {"ancient alloy plate", new Material("Ancient Alloy Plate", "Craftable Material")}
        };
    }
}
