using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    internal class Lunch : Food
    {
        public bool IsCombo { get; }
        // lunch requires a name, price, point value, checks if heated and if its a combo.
        public Lunch(string name, double price, int points, bool isHeated, bool isCombo) : base(name, price, points, isHeated)
        {
            IsCombo = isCombo;
        }

        public override string ToString()
        {
            return "Lunch " + base.ToString() + $" - Combo: {IsCombo}";
        }
    }
}
