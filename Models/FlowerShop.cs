using System;
using System.Collections.Generic;

namespace MyFlowerShop
{
    public class FlowerShop
    {
        public List<Lavender> lavenderList { get; set; }
        public List<Lily> lilyList { get; set; }
        public List<Lotus> lotusList { get; set; }
        public List<Rose> roseList { get; set; }

        public List<IColorfulFlower> makeMothersDayBouquet()
        {
            return new List<IColorfulFlower> {
                new Rose(){Color = "Pink", Price = 10.25},
                new Lotus(){Color = "Blue", Price = 12.50},
                new Lavender(){Color = "Lavender", Price = 10.25},
                new Rose(){Color = "Red", Price = 12.50},
                new Lotus(){Color = "Turqouise", Price = 6.75},
                new Lavender(){Color = "Yellow", Price = 6.75}

            };
        }
        public List<IStemFlower> makeFathersDayBouquet(){
            return new List<IStemFlower>{
                new Lily(){StemLength = 4.5},
                new Rose(){StemLength = 11},
                new Lily(){StemLength = 4.5},
                new Rose(){StemLength = 9},
                new Lily(){StemLength = 6},
                new Rose(){StemLength = 13}
            };
        }

    }
}