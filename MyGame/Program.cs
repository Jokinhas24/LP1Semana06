using System;
using System.Security.Cryptography.X509Certificates;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int count = int.Parse(args[0]);

            Enemy [] enemies = new Enemy[count];

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enemy {i + 1} name: ");
                enemies[i] = new Enemy(Console.ReadLine());
            }

            // Combat sequence
            ShowStats(enemies);
            enemies[0].TakeDamage(50);
            ShowStats(enemies);
            enemies[0].PickupPowerUp(PowerUp.Health, 75);
            ShowStats(enemies);
            enemies[0].PickupPowerUp(PowerUp.Shield, 80);
            ShowStats(enemies);
            enemies[0].TakeDamage(120);
            ShowStats(enemies);
        }
        private static void ShowStats(Enemy[] enemies)
        {
            Console.WriteLine("");
            foreach (Enemy enemy in enemies)
            {
                Console.Write($"Name is {enemy.GetName()}: HP is {enemy.GetHealth()}");
                Console.WriteLine($" and shield is {enemy.GetShield()}.");
            }
        }
    }
}
