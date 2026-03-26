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
            foreach (Enemy enemy in enemies)
            {
                Console.WriteLine($"Name is {enemy.GetName()} and HP is {enemy.GetHealth()}");
            }
        }
    }
}
