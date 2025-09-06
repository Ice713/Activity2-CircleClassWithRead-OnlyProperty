using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity2_CircleClassWithRead_OnlyProperty
{
    internal class Circle
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Radius
        {
            get { return radius; }
        }
        public double Area
        {
            get { return Math.PI * radius * radius; }
        }
    }
}
