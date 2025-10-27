using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firgures
{
    public class Rectangle : Figure
    {
        private double Width;
        private double Height;
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double getWidth()
        {
            return Width;
        }
        public double getHeight()
        {
            return Height;
        }
        public void setWidth(double value) 
        {
            Width = value;
        }
        public void setHeight(double value)
        {
            Height = value;
        }
        public override double calculatePerimeter()
        {
            return (Width + Height) * 2;
        }
        public override double calculateArea()
        {
            return Width * Height;
        }
        public override string Draw()
        {
            return "Rectangle!";
        }
    }
}
