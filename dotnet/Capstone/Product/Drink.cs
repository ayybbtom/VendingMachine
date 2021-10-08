using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Drink : Product
    {
        public Drink(decimal price, string name, string slotLocation) : base("Glug Glug, Yum!", price, name, slotLocation)
        {
        }



    }
}
