using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firgures
{
    public class Circle : Figure
    {
        private double Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double getRadius() 
        {
            return Radius;
        }
        public void setRadius(double value) 
        {
            Radius=value;
        }
        public override double calculatePerimeter() 
        {
            return 2 * Math.PI * Radius;
        }
        public override double calculateArea() 
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override string Draw()
        {
            return "Circle!";
        }
    }
}
