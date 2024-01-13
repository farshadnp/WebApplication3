using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstractions.Shapes.Implementation
{
    internal class Rectangle : Shape
    {

        public override double CalculateArea(double width, double length, double radius, int side)
        {
            return length * width;
        }

        public override double CalculatePerimeter(double width, double length, double radius, int side)
        {
            return 2 * (length + width);
        }
    }
}
