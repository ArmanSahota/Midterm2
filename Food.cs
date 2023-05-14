using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    abstract class Food : Product
    {
        public bool IsHeated { get; }
        // it needs the foods name, price, points, and checks if its heated or not.
        public Food(string name, double price, int points, bool isHeated) : base(name, price, points)
        {
            IsHeated = isHeated;
        }

        public override string ToString()
        {
            return base.ToString() + $" - Heated: {IsHeated}";
        }
    }
}
