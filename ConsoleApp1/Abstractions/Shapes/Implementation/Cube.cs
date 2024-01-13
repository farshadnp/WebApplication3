using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstractions.Shapes.Implementation
{
    public class Cube : Shape
        // بهتر بود به جای کلاس ابسترکت از اینترفیس استفاده میکردیم.
    {
        public override double CalculateArea(double width, double length, double radius, int side) // سطح
        {
            return 6 * Math.Pow(side, 2);
        }

        public override double CalculatePerimeter(double width, double length, double radius, int side) // حجم
        {
            return Math.Pow(side, 3);
        }
    }
}
