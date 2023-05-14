using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    internal class GiftCard : Product
    {
        public double Amount { get; }
        // checks name, price, points, and sent the amount the giftcard is worth.
        public GiftCard(string name, double price, int points, double amount) : base(name, price, points)
        {
            amount = Amount;
        }
        public override string ToString()
        {
            return base.ToString() + $" - GiftCard: {Amount}";
        }

    }
}
