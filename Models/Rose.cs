using System;

namespace MyFlowerShop
{
    public class Rose : IColorfulFlower, IStemFlower
    {
        public bool HasThorns { get; set; }
        public double StemLength { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"A {Color} rose is {Price:c}";
        }
    }
}