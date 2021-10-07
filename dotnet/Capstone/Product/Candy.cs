using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Candy : Product
    {
        public Candy(string sound, decimal price, string name, string slotLocation) : base(sound, price, name, slotLocation)
        {
            Sound = "Munch Munch, Yum";
        }



    }
}
