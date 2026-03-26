using System;
using System.Security.Cryptography.X509Certificates;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Enemy [] enemies = new Enemy[int.Parse(args[0])];
            Enemy loki = new Enemy("Loki");
            loki.SetName("   Grindaalokki   ");
            //foreach (Enemy in )
            Console.WriteLine($"Name is {loki.GetName()} and HP is {loki.GetHealth()}");
        }
    }
}
