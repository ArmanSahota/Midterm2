using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Midterm2
{   
    // abstract class meaning there can't be a member called member.
    public abstract class Member
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MemberNumber { get;  set; }
        public int PointAmount { get;  set; }
        public DateTime MemberSince { get;  set; }
        public ObservableCollection<Product> PreviousTransactions { get;  set; }

        public Member(string firstName, string lastName)
        {
            // gets the members first name, last name, gives them a member number, starts their points off at 0, gets the current date as the date they join,
            // and creates a list for them to see their previous trasactions
            FirstName = firstName;
            LastName = lastName;
            MemberNumber = new Random().Next(1000000, 10000000);
            PointAmount = 0;
            MemberSince = DateTime.Now;
            PreviousTransactions = new ObservableCollection<Product>();
        }
        public object _previousTransactions { get; }

        public abstract void DeductPoints(Product product);
        public abstract void AddPoints(Product product);
        // add product is used to add a product into the previous trasnaction observable list
        public void AddProduct(Product product)
        {
            PreviousTransactions.Add(product);
        }
    

    public override string ToString()
        {
            return $"{GetType().Name}: {FirstName} {LastName} - Points ({PointAmount}) - Member Number ({MemberNumber})";
        }
    }
}
