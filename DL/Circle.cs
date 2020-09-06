using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{

    public class Circle
    {
        public const double pi = 3.14;
        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
            Length = Radius * 2 * pi;
            Area = Math.Pow(Radius, 2) * pi;
        }
        public Point Center { get; set; }
        public double Length { get; set; }
        public double Radius { get; set; }
        public double Area { get; set; }

        public static bool Compare(Circle c1, Circle c2)
        {
            if (c1.Area == c2.Area)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}
