using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Chip : Product
    {
        public Chip(string sound, decimal price, string name, string slotLocation) : base(sound, price, name, slotLocation)
        {
            Sound = "Crunch Crunch, Yum!";
        }



    }
}
