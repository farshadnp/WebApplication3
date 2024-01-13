using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstractions.Shapes.Implementation
{
    public class Circle : Shape
    {
        public override double CalculateArea(double width, double length, double radius, int side)
        {
            return PI * Math.Pow(radius,2);
        }

        public override double CalculatePerimeter(double width, double length, double radius, int side)
        {
            return 2 * PI * radius;
        }
    }
}
