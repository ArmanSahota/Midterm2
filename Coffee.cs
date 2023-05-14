using Midterm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    internal class Coffee : Drink
    {
        private readonly string roast;

        // Constructor
        // for coffee we need the name, price, point amount, size, and optional roast amount.
        public Coffee(string name, double price, int points, Size size, string roast) : base(name, price, points, size)
        {
            this.roast = roast;
        }

        // Methods
        // add the optional roast amount.
        public override string ToString()
        {
            return "Coffee " + base.ToString() + " - " + roast ;
        }
    }
}
