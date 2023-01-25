using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningarcirkel
{
    class Circle
    {
        private double radius = 1.0;

        public Circle()
        {
        }

        public Circle(double radius)
        {
            SetRadius(radius);
        }

        public double GetRadius()
        {
            return radius;
        }

        public void SetRadius(double radius)
        {
            if (radius > 0)
            {
                this.radius = radius;
            }
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * radius;
        }

        public override string ToString()
        {
            return "Radius: " + radius + ", Area: " + GetArea() + ", Circumference: " + GetCircumference();
        }
    }

}

