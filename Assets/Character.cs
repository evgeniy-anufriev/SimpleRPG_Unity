using UnityEngine;
using System.Reflection;
using System;
using System.Collections.Generic;





public class Character : MonoBehaviour//, ICloneable
    {
    public static System.Random rand = new System.Random();
    public Rigidbody body = null;
    void Start()
    {
        this.body = this.GetComponent<Rigidbody>() ?? this.gameObject.AddComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
         
        public new String name;
        public String charClass;
        public int base_strength;
        public int base_dexterity;
        public int base_endurance;
        public int base_intelect;
        public int strength;
        public int dexterity;
        public int endurance;
        public int intelect;
        public int hpMax;

        public int level;

    // Secondary stats
        public int attack;
        public int hp;
        public bool life;
        protected int defense;
        protected int stamina;
        protected int staminaMax; 
        protected int magic;
        protected int magicResistance;
        protected float critChance;
        protected float critMultiplier;
        protected int avoidChance;
        protected int parryChance;
        protected bool blockStance;
     
        // protected Inventory myInv;

        public void Character_init(String name, String charClass, int strength, int dexterity, int endurance, int intelect)
        {
            this.name = name;
            this.charClass = charClass;
            this.strength = this.base_strength = strength;
            this.dexterity = this.base_dexterity = dexterity;
            this.endurance = this.base_endurance = endurance;
            this.intelect = this.base_intelect = intelect;


        }

        public void calcSecondaryStats()
        {
            life = true;
            level = 1;
            attack = strength * 2;
            hpMax = endurance * 20;
            defense = (int)((2 * strength + dexterity * 0.5f) / 2.0f);
            critChance = dexterity + (100f / (100f + dexterity));
            critMultiplier = 1.2f + (dexterity) / 20.0f;
            avoidChance = (int)(dexterity / 2) + (int)(dexterity / 5.0f);
            parryChance = (int)(strength / 2) + (int)(strength / 5.0f);
            magic = intelect * 20;
            staminaMax = endurance * 20 + strength * 5;
            magicResistance = (int)(intelect / 2.0f);
            hp = hpMax;
            stamina = staminaMax;

        }

        public int makeAttack()
        {

            int minAttack = (int)(attack * 0.8f);
            int deltaAttack = (int)(attack * 0.4f * (stamina * (1.0f / staminaMax)));
            int currentAttack = minAttack + rand.Next(deltaAttack);
            stamina -= rand.Next(strength * 2, strength * 3);
            if (stamina < 0) stamina = 0;
            if (critChance > rand.NextDouble() * 100)
            {
                currentAttack *= (int)critMultiplier;
                print("\n " + this.name + " провел критическую атаку на : " + currentAttack + " ед. урона");
            }
            else print("\n " + this.name + " провел обычную атаку на: " + currentAttack + " ед. урона");

            return currentAttack;
        }

        public void getDamage(int damage)
        {
            if (avoidChance > rand.Next(100)) print("\n" + this.name + " уклонился от удара!");
            else
            {
                damage -= rand.Next(defense);
                if (blockStance)
                {
                    damage -= rand.Next(defense);
                    print("\n" + this.name + " заблокировал часть урона.");

                }

                if (damage < 0)
                {
                    damage = 0;
                    print("\n" + this.name + " не получил урона.");
                }
                print("\n" + this.name + " получил " + damage + " ед.урона");
                hp -= damage;
                if (hp <= 0)
                {
                    print("\n" + this.name + " погиб!");
                    life = false;
                }


            }


        }

        /* public System.Object Clone() // Копирование объектов 
         {

             return base.MemberwiseClone();

         }*/
        public void getFullInfo()
        {
            Console.WriteLine("Имя: " + name + " Класс: " + charClass + " Уровень " + level);
            Console.WriteLine("Макс.здоровья " + hpMax + " Выносливость " + stamina + " Мана " + magic);
            Console.WriteLine("Шанс крита " + critChance + " Модификатор крита " + critMultiplier);
            Console.WriteLine("Защита " + defense + " Шанс уклонения " + avoidChance + " Сопротивление магии " + magicResistance);
        }

        public void getInfo()
        {
            Console.WriteLine("Имя: " + name + " Здоровье: " + hp + "/" + hpMax + " Выносливость: " + stamina + "/" + staminaMax + " Уровень: " + level);
        }


}

