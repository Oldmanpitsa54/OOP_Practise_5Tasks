using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
    public class Trapezoid
    {

        public Point Alpha { get; set; }
        public Point Bravo { get; set; }
        public Point Charlie { get; set; }
        public Point Delta { get; set; }

        public Trapezoid(Point alpha, Point bravo, Point charlie, Point delta)
        {
            Alpha = alpha;
            Bravo = bravo;
            Charlie = charlie;
            Delta = delta;
            TopLine = Charlie.X - Bravo.X;
            BotLine = Charlie.X - Alpha.X;
            Height = Bravo.Y - Alpha.Y;
            MidLine = (TopLine + BotLine) / 2;
            Side1 = Side(Alpha, Bravo);
            Side2 = Side(Charlie, Delta);
        }

        private double height;
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        private double topLine;
        public double TopLine
        {
            get { return topLine; }
            set
            {
                topLine = value;
            }
        }

        private double botLine;
        public double BotLine
        {
            get { return botLine; }
            set
            {
                botLine = value;
            }
        }

        private double midLine;
        public double MidLine
        {
            get { return midLine; }
            set
            {
                midLine = value;
            }
        }
        public double Side(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2));
        }

        private double side1;
        public double Side1
        {
            get { return side1; }
            set
            {
                side1 = value;
            }
        }

        private double side2;
        public double Side2
        {
            get { return side2; }
            set
            {
                side2 = value;
            }
        }

        public double Perimeter()
        {
            return TopLine + BotLine + Side1 + Side2;
        }

        public double Area()
        {
            return MidLine * Height;
        }
        public bool AreEqual()
        {
            if (Side1 == Side2)
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
