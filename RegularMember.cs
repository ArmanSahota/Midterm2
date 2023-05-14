using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    internal class RegularMember : Member
{
    public RegularMember(string firstName, string lastName) : base(firstName, lastName)
    {
    }
       // regular member lose the amount displayed and gain the amount displayed
        public override void DeductPoints(Product product)
        {
            PointAmount -= product.Points;
        }

        public override void AddPoints(Product product)
        {
            PointAmount += product.Points;
        }

        public override string ToString()
    {
            return base.ToString() + $"{FirstName} - {LastName} - Points: {PointAmount} - Member Number: {MemberNumber}";
        }
}
}
