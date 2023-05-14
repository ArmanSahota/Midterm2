using Midterm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    internal class Tea : Drink
    {
        // Fields
        private readonly string teaType;

        // Constructor
        // tea requires the name, price, points, size, and the tea type.
        public Tea(string name, double price, int points, Size size, string teaType) : base(name, price, points, size)
        {
            this.teaType = teaType;
        }

        // Methods
        public override string ToString()
        {
            return "Tea " + base.ToString() + " - " + teaType;
        }
    }
}

