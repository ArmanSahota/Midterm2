using Midterm2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class Tumbler : Merchandise
{
    public string Color { get; }

        // tumbler requires the name, price, poins amount, and color
    public Tumbler(string name, double price, int points, string color) : base(name, price, points)
    {
        Color = color;
    }

    public override string ToString()
    {
        return base.ToString() + $" - Color: {Color}";
    }
}
}
