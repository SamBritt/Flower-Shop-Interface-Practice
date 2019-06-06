using System;

namespace MyFlowerShop
{
    public class Lotus : IColorfulFlower
    {
        public double Price { get; set; }
        public bool inSeason { get; set; }
        public string Color { get; set; }

        public bool isPoisonous { get; set; }

        public bool isFlying { get; set; }

        public override string ToString()
        {
            return $"A {Color} Lotus is {Price:c}";
        }
    }
}