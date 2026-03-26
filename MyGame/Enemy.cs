using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;
        static float numberOfPowerUpsTaken;

        public Enemy(string name)
        {
            this.name = SetName(name);
            health = 100;
            shield = 0;
        }

        static Enemy()
        {
            //numberOfPowerUpsTaken = 0;
        }

        public string GetName()
        {
            return name;
        }
        public float GetHealth()
        {
            return health;
        }
        public float GetShield()
        {
            return shield;
        }
        public float GetNumberPowerUps()
        {
            return numberOfPowerUpsTaken;
        }

        public string SetName(string newname)
        {
            if (newname.Length <= 8)
            {
                name = newname;
            }
            else
            {
                name = newname.Substring(0, 8);
            }
            return name;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

        public void PickupPowerUp(PowerUp power, float amount)
        {
            if (power == PowerUp.Health)
            {
                if (health + amount < 100)
                {
                    health += amount;
                }
                else
                {
                    health = 100;
                }
            }
            else if(power == PowerUp.Shield)
            {
                if (shield + amount < 100)
                {
                    shield += amount;
                }
                else
                {
                    shield = 100;
                }
            }
        }
    }
}