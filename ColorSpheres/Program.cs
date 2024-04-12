using System;
using System.Reflection.Metadata;

namespace ColorSpheres
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
            byte r1 = sphere1.color.GetRed();
            byte g1 = sphere1.color.GetGreen();
            byte b1 = sphere1.color.GetBlue();
            byte a1 = sphere1.color.GetAlpha();

            Console.WriteLine($"1st Sphere's color is ({r1},{g1},{b1},{a1}).");
            Console.WriteLine($"1st SPhere's Grey Scale is {sphere1.color.GetGrey()}.");
            Console.WriteLine($"1st Sphere's radius is {sphere1.radius}.");
            Console.WriteLine($"1st Sphere was thrown {sphere1.GetTimesThrown()} times.");

            // Sphere 2
            byte r2 = sphere2.color.GetRed();
            byte g2 = sphere2.color.GetGreen();
            byte b2 = sphere2.color.GetBlue();
            byte a2 = sphere2.color.GetAlpha();

            Console.WriteLine($"\n2nd Sphere's color is ({r2},{g2},{b2},{a2}).");
            Console.WriteLine($"2nd SPhere's Grey Scale is {sphere2.color.GetGrey()}.");
            Console.WriteLine($"2nd Sphere's radius is {sphere2.radius}.");
            Console.WriteLine($"2nd Sphere was thrown {sphere2.GetTimesThrown()} times.");
            
            // Sphere 3
            byte r3 = sphere3.color.GetRed();
            byte g3 = sphere3.color.GetGreen();
            byte b3 = sphere3.color.GetBlue();
            byte a3 = sphere3.color.GetAlpha();

            Console.WriteLine($"\n3rd Sphere's color is ({r3},{g3},{b3},{a3}).");
            Console.WriteLine($"3rd SPhere's Grey Scale is {sphere3.color.GetGrey()}.");
            Console.WriteLine($"3rd Sphere's radius is {sphere3.radius}.");
            Console.WriteLine($"3rd Sphere was thrown {sphere3.GetTimesThrown()} times.");
        }
    }
}
