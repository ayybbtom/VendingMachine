using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public abstract class Product
    {
        public string Sound { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string SlotLocation { get; set; }

        public Product(string sound, decimal price, string name, string slotLocation)
        {
            Sound = sound;
            Price = price;
            Name = name;
            SlotLocation = slotLocation;
        }

    }
}
