using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public abstract class Figure
    {
        protected const double pi = 3.14;
        public double OutlineLength { get; set; }
        public double Area { get; set; }
        public abstract void ShowInfo();
    }

    public class Triangle : Figure
    {
        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            OutlineLength = Side1 + Side2 + Side3;
            HalfPerimeter = OutlineLength / 2;
            Area = Math.Sqrt(HalfPerimeter * (HalfPerimeter - Side1) * (HalfPerimeter - Side2) * (HalfPerimeter - Side3));
        }
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public double HalfPerimeter { get; set; }

        public override void ShowInfo()
        {
            Console.WriteLine($"{nameof(Triangle)}\nFirst side = {Side1}, second side = {Side2}, third side = {Side3}.\nPerimeter = {OutlineLength}, area = {Area}.\n");
        }
    }

    public class Ring : Figure
    {

        public Ring(double radius)
        {
            Radius = radius;
            OutlineLength = 2 * Radius * pi;
            Area = Math.Pow(Radius, 2) * pi;
        }
        public double Radius { get; set; }

        public override void ShowInfo()
        {
            Console.WriteLine($"{nameof(Ring)}\nRadius = .\nCircle length = {OutlineLength}, area = {Area}.\n");
        }
    }

    public class Rectangle : Figure
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
            OutlineLength = (Length + Width) * 2;
            Area = Length * Width;
        }
        public double Length { get; set; }
        public double Width { get; set; }

        public override void ShowInfo()
        {
            Console.WriteLine($"{nameof(Rectangle)}\nFirst side = {Length}, second side = {Width}.\nPerimeter = {OutlineLength}, area = {Area}.\n");
        }
    }

    public class Square : Figure
    {
        public Square(double side)
        {
            Side = side;
            OutlineLength = Side * 4;
            Area = Math.Pow(Side, 2);
        }
        public double Side { get; set; }

        public override void ShowInfo()
        {
            Console.WriteLine($"{nameof(Square)}\nSide = {Side}. Perimeter = {OutlineLength}, area = {Area}.\n");

        }
    }

    public class Ellipse : Figure
    {
        public Ellipse(double halfAxis1, double halfAxis2)
        {
            HalfAxis1 = halfAxis1;
            HalfAxis2 = halfAxis2;
            OutlineLength = 4 * (Area + Math.Pow((HalfAxis1 - HalfAxis2), 2)) / (HalfAxis1 + HalfAxis2);
            Area = pi * HalfAxis1 * HalfAxis2;
        }
        public double HalfAxis1 { get; set; }
        public double HalfAxis2 { get; set; }

        public override void ShowInfo()
        {
            Console.WriteLine($"{nameof(Ellipse)}\n First axis = {HalfAxis1 * 2}, second axis = {HalfAxis2 * 2}. Ellipse length = {OutlineLength}, area = {Area}.\n");

        }
    }
}
