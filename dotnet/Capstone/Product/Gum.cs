using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Gum : Product
    {
        public Gum(string sound, decimal price, string name, string slotLocation) : base(sound, price, name, slotLocation)
        {
            Sound = "Chew Chew, Yum!";
        }



    }
}
