using System;

namespace MyFlowerShop
{
    public class Lavender : IColorfulFlower
    {

        public string Color { get; set; }

        public double StemLength { get; set; }

        public bool isPoisonous { get; set; }

        public double Price { get; set; }
        public override string ToString()
        {
            return $"A {Color} Lavender is {Price:c}";
        }
    }
}