using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class Furniture
    {
        public Furniture(string type, string colour, double size, double weight, string manufacturer)
        {
            FurnitureType = type;
            Colour = colour;
            Size = size;
            Weight = weight;
            Manufacturer = manufacturer;
        }
        public string FurnitureType { get; set; }
        public string Colour { get; set; }
        public double Size { get; set; }
        public double Weight { get; set; }
        public string Manufacturer { get; set; }
    }
    public class Material
    {
        public Material(double size, double cost)
        {
            Size = size;
            Cost = cost;
        }
        public double Size { get; set; }
        public double Cost { get; set; }
    }
}
