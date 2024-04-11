using System;

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
        }
    }
}
