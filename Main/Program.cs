using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong cases;
            string input;
            do
            {
                Console.Write("Choose the task: \n1) Trapezoid \n2) Circles \n3) Figures \n4) Furniture store \n5) Flowers \n 6) Exit \nYour choice: ");
                input = Console.ReadLine();
                Validation.Ulong_Digits_check(input, out cases);
                switch (cases)
                {
                    case 1:

                        Trapezoid trus = new Trapezoid(new Point(1, 1), new Point(2, 5), new Point(7, 5), new Point(8, 1));
                        Trapezoid balbes = new Trapezoid(new Point(3, 9), new Point(4, 11), new Point(5, 11), new Point(6, 9));
                        Trapezoid byvalyi = new Trapezoid(new Point(10, 9), new Point(11, 10), new Point(13, 10), new Point(14, 9));
                        Trapezoid zhmyx1 = new Trapezoid(new Point(11, 3), new Point(13, 6), new Point(16, 6), new Point(18, 3));
                        double midAreaValue = (trus.Area() + balbes.Area() + byvalyi.Area() + zhmyx1.Area()) / 4;
                        Trapezoid[] arr = new Trapezoid[4];
                        arr[0] = trus;
                        arr[1] = balbes;
                        arr[2] = byvalyi;
                        arr[3] = zhmyx1;
                        int amount = 0;
                        foreach (Trapezoid value in arr)
                        {
                            if (value.Area() > midAreaValue)
                            {
                                amount++;
                            }
                        }
                        Console.WriteLine($"The side of first trapezoid is {trus.Perimeter()},\n sides of this trapezoid: {trus.TopLine}, {trus.BotLine}, {trus.Side1}, {trus.Side2},\n area: {trus.Area()}, middle line: {trus.MidLine},\n is Trapezoid right? {trus.AreEqual()}. Amount of bigger than middle area value: {amount}\n");

                        break;


                    case 2:
                        Circle centralCircle = new Circle(new Point(0, 0), 12);
                        Circle outsideCircle = new Circle(new Point(3, 5), 11);
                        Console.WriteLine($"The radius of the circle with center int the point ({centralCircle.Center.X};{centralCircle.Center.Y}) is {centralCircle.Radius} circle length: {centralCircle.Length},\ncircle area: {centralCircle.Area}, is equal to circle with center in ({outsideCircle.Center.X};{outsideCircle.Center.Y})? {Circle.Compare(centralCircle, outsideCircle)}\n");
                        break;

                    case 3:
                        Triangle triangle = new Triangle(3, 4, 5);
                        Ring ring = new Ring(4);
                        Rectangle rectangle = new Rectangle(4, 6);
                        Square square = new Square(3);
                        Ellipse ellipse = new Ellipse(4.5, 3.3);

                        Figure[] figuresBox = new Figure[] { triangle, ring, square, ellipse, rectangle };
                        foreach(Figure value in figuresBox)
                        {
                            value.ShowInfo();
                        }
                        break;

                    case 6:
                        return;

                    default:
                        Console.WriteLine("Error. Choose the menu item again.\n");
                        break;
                }
            } while (true);

        }
        
    }
}
