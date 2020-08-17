using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Echilateral : Triangle
    {
        public Echilateral(double latura) : base(latura, latura * Math.Sqrt(3) / 2)
        {
        }
    }
}
