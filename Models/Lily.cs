using System;

namespace MyFlowerShop
{

    public class Lily : IStemFlower
    {
        public bool inSeason{get;set;}

        public double StemLength { get; set; }

        public bool isPoisonous { get; set; }

        public double Price { get; set; }
    }
}