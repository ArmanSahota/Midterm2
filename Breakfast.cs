using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    internal class Breakfast : Food
{
    public bool HasDairy { get; }
    public bool Heated { get; }

        // breakfast gets the name, price, points, checks if its heated, or has dairy
    public Breakfast(string name, double price, int points, bool isHeated, bool hasDairy) : base(name, price, points, isHeated)
    {
        HasDairy = hasDairy;
            Heated = isHeated;
    }
        // on top of the toString we need to add if it has dairy or not. 
    public override string ToString()
    {
        return "Breakfast " + base.ToString() + $" - Dairy: {HasDairy}";
    }
}
}
