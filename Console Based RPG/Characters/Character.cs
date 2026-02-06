using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.Characters
{
    internal class Character
    {
        private int baseHealth;
        private int currentHealth;

        private int baseArmor;
        private int bonusArmor;

        private int baseDamage;
        private int bonusDamage;


        public int Health
        { 
            get { return baseHealth; }
        }
        public int CurrentHealth
        {
            get { return currentHealth; }
        }
        public int TotalArmor
        {
            get { return baseArmor + bonusArmor; }
        }
        public int TotalDamage
        { 
            get { return baseDamage + bonusDamage; } 
        }

        public Character(int health, int armor, int damage) 
        {
            baseHealth = health;
            currentHealth = health;
            baseArmor = armor;
            baseDamage = damage;
        }

        public void EquipArmor(int armorBonus)
        { 
            bonusArmor += armorBonus;
        }

        public void EquipWeapon(int weaponBonus)
        {
            bonusDamage += weaponBonus;
        }
        //To do
        //Heal
        //Take Damage
        public void ShowCharacterStats()
        {
            Console.WriteLine($"Health: {CurrentHealth}/{Health}");
            Console.WriteLine($"Armor: {TotalArmor}");
            Console.WriteLine($"Damage: {TotalDamage}");
        }
        
    }
}
