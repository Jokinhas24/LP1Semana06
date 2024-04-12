using System;
using System.Reflection.Metadata;

namespace BetterColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Color red = new Color(250, 0, 0);
            Color cyan = new Color(20, 180, 240, 30);
            Color black = new Color(0, 0, 0);

            Sphere sphere1 = new Sphere(red, 30);
            Sphere sphere2 = new Sphere(cyan, 20);
            Sphere sphere3 = new Sphere(black, 40);

            for (int i = 0; i < 10; i++)
            {
                sphere1.Throw();
                if (i < 5)
                {
                    sphere2.Throw();
                }
            }
            sphere3.Throw();
            sphere3.Pop();
            sphere3.Throw();

            // Sphere 1
            byte r1 = sphere1.Color.Red;
            byte g1 = sphere1.Color.Green;
            byte b1 = sphere1.Color.Blue;
            byte a1 = sphere1.Color.Alpha;

            Console.WriteLine($"1st Sphere's color is ({r1},{g1},{b1},{a1}).");
            Console.WriteLine($"1st SPhere's Grey Scale is {sphere1.Color.GetGrey(r1,g1,b1)}.");
            Console.WriteLine($"1st Sphere's radius is {sphere1.Radius}.");
            Console.WriteLine($"1st Sphere was thrown {sphere1.GetTimesThrown()} times.");

            // Sphere 2
            byte r2 = sphere2.Color.Red;
            byte g2 = sphere2.Color.Green;
            byte b2 = sphere2.Color.Blue;
            byte a2 = sphere2.Color.Alpha;

            Console.WriteLine($"\n2nd Sphere's color is ({r2},{g2},{b2},{a2}).");
            Console.WriteLine($"2nd SPhere's Grey Scale is {sphere2.Color.GetGrey(r2,g2,b2)}.");
            Console.WriteLine($"2nd Sphere's radius is {sphere2.Radius}.");
            Console.WriteLine($"2nd Sphere was thrown {sphere2.GetTimesThrown()} times.");
            
            // Sphere 3
            byte r3 = sphere3.Color.Red;
            byte g3 = sphere3.Color.Green;
            byte b3 = sphere3.Color.Blue;
            byte a3 = sphere3.Color.Alpha;

            Console.WriteLine($"\n3rd Sphere's color is ({r3},{g3},{b3},{a3}).");
            Console.WriteLine($"3rd SPhere's Grey Scale is {sphere3.Color.GetGrey(r3,g3,b3)}.");
            Console.WriteLine($"3rd Sphere's radius is {sphere3.Radius}.");
            Console.WriteLine($"3rd Sphere was thrown {sphere3.GetTimesThrown()} times.");
        }
    }
}
