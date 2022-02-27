using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5Library
{
    public class Cone
    {
        private int Radius { get; set; }
        private int Height { get; set; }

        public Cone(int radius, int height)
        {
            Radius = radius;
            Height = height;
        }
        public double BaseArea ()
        {
            return Math.PI * Radius * Radius;
        }
        public double TotalSurfaceArea ()
        {
            return Math.PI * Radius * (Radius + Height);
        }
    }
}
