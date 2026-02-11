using Console_Based_RPG.Core;
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

        private int baseStrenght;
        private int bonusStrenght;

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

        public int TotalStrenght
        {
            get { return baseStrenght + bonusStrenght; }
        }


        public Character(int health, int armor, int damage, int strenght) 
        {
            baseHealth = health;
            currentHealth = health;
            baseArmor = armor;
            baseDamage = damage;     
            baseStrenght = strenght;
        }

        public void EquipArmor(int armorBonus)
        {
            bonusArmor += armorBonus;
        }

        public void EquipWeapon(int weaponBonus)
        {
            bonusDamage += weaponBonus;
        }
         

        public void UnequipArmor(int armorBonus)
        { 
            bonusArmor -= armorBonus;
        }

        public void UnequipWeapon(int weaponBonus)
        {
            bonusDamage -= weaponBonus;
        }

        public void IncreaseStrenght(int strenghtBonus)
        {
            strenghtBonus += bonusStrenght;
        }


        public bool ReduceStrenght(int strenghtCost)
        {
            if (baseStrenght < strenghtCost)
            {
                currentHealth -= strenghtCost;
                return false;
            }
            baseStrenght -= strenghtCost;
            return true;
        }

        public bool ReduceHealth(int healthCost)
        {
            if (currentHealth <= 0)
            {
                return false;
            }
            currentHealth -= healthCost;
            return true;
        }

        public void IncreaseHealth(int healthBonus)
        {
            currentHealth += healthBonus;
        }

        //To do
        public void ShowCharacterStats()
        {
            Console.WriteLine($"Health: {CurrentHealth}/{Health}");
            Console.WriteLine($"Armor: {TotalArmor}");
            Console.WriteLine($"Damage: {TotalDamage}");
            Console.WriteLine($"Strenght: {TotalStrenght}");
        }
        
    }
}
