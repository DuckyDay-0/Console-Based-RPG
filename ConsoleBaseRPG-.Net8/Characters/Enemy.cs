using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.Characters
{
    internal class Enemy : Character
    {
        public string Name { get; }
        public Enemy(string name ,int health, int armor, int damage, int strenght) : base(health, armor, damage, strenght)
        {
            this.Name = name;
        }
    }
}
