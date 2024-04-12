using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Sphere
    {
        public Color Color { get; set; }
        public int Radius { get; set; }
        public int Times_thrown { get; set; }

        public Sphere(Color color, int radius)
        {
            Color = color;
            Radius = radius;
            Times_thrown = 0;
        }

        public void Pop()
        {
            Radius = 0;
        }
        public void Throw()
        {
            if (Radius > 0)
            {
                Times_thrown += 1;
            }
        }
        public int GetTimesThrown()
        {
            return Times_thrown;
        } 
    }
}