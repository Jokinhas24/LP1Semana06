using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        public int color;
        public int radius;
        public int thrown_times;

        public Sphere(int color, int radius)
        {
            this.color = color;
            this.radius = radius;
            thrown_times = 0;
        }

        static Pop()
        {
            radius = 0;
        }
    }
}