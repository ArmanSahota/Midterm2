using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    internal class Mug :Merchandise
    {
        public string Design { get; }
        // mug needs the name, price, points, and the type of desing for the mug.
        public Mug(string name, double price, int points, string design) : base(name, price, points)
        {
            Design = design;
        }

        public override string ToString()
        {
            return "Mug" + base.ToString() + $" - Design: {Design}";
        }
    }
}
