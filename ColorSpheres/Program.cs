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
            byte color_1 = sphere1.Color.Red;

            Console.WriteLine($"1st Sphere's color is {sphere1.Color()}");
            Console.WriteLine($"1st SPhere's Grey level is {sphere1.GetGrey(sphere1.Color())}");
            Console.WriteLine($"1st Sphere's radius is {sphere1.Radius}");
            Console.WriteLine($"1st Sphere was thrown {sphere1.GetTimesThrown()} times");

            Console.WriteLine($"2nd Sphere was thrown {sphere2.GetTimesThrown()} times");
            Console.WriteLine($"3rd Sphere was thrown {sphere3.GetTimesThrown()} times");
        }
    }
}
