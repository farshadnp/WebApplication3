using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstractions.Shapes
{
    public abstract class Shape
    {
        public const double PI = Math.PI; 
        public abstract double CalculateArea(double width, double length, double radius, int side); // مساحت
        public abstract double CalculatePerimeter(double width, double length, double radius, int side); // محیط
    }
}
