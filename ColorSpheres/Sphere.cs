using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        public Color color;
        public int radius;
        public int times_thrown;

        public Sphere(Color color, int radius)
        {
            this.color = color;
            this.radius = radius;
            times_thrown = 0;
        }

        public void Pop()
        {
            radius = 0;
        }
        public void Throw()
        {
            if (radius > 0)
            {
                times_thrown += 1;
            }
        }
        public int GetTimesThrown()
        {
            return times_thrown;
        }
    }
}