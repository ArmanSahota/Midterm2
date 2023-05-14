using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    internal class GoldMember : Member
    {
        public GoldMember(string firstName, string lastName) : base(firstName, lastName)
        {
        }
        // gold member perks are you lose less points and you gain 50 more points when.
        public override void DeductPoints(Product product)
        {
            PointAmount -= product.Points / 2;
        }

        public override void AddPoints(Product product)
        {
            PointAmount += product.Points + 50;
        }

        public override string ToString()
        {
            return base.ToString() + $"{FirstName} - {LastName} - Points: {PointAmount} - Member Number: {MemberNumber}";
            
        }
    }
}
