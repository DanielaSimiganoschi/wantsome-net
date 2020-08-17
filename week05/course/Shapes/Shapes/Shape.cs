using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
   public abstract class Shape
    {
       protected double width, height;

        public abstract double CalculateSurface();

        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
    }
}
