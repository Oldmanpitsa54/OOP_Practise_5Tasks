using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public abstract class Flower
    {
        public abstract double Cost { get; set; }
        public abstract string Colour { get; set; }
    }
    public class Carnation : Flower
    {
        public Carnation(string colour)
        {
            Colour = colour;
            Cost = 25;

        }
        public override double Cost { get; set; }
        public override string Colour { get; set; }
    }

    public class Rose : Flower
    {
        public Rose(string colour)
        {
            Colour = colour;
            Cost = 30;

        }
        public override double Cost { get; set; }
        public override string Colour { get; set; }
    }

    public class Tulip : Flower
    {
        public Tulip(string colour)
        {
            Colour = colour;
            Cost = 20;

        }
        public override double Cost { get; set; }
        public override string Colour { get; set; }
    }
}
