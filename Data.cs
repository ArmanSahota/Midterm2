using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    public static class Data
    {
        public static class DataClass
        {
            // Observable Collections for Members and Products
            static ObservableCollection<Member> memberCollection = new ObservableCollection<Member>();
            static ObservableCollection<Product> productCollection = new ObservableCollection<Product>();
            

            // Current Product and Current Member
            static Product currentProduct = null;
            static Member currentMember = null;
           
            

            // Static Constructor
            static DataClass()
            {
                // Initialize both observable collections here
                memberCollection = new ObservableCollection<Member>();
                productCollection = new ObservableCollection<Product>();
               
            }

            // Static Properties (All sets done by methods)
            public static ObservableCollection<Member> MemberCollection
            {
                get { return memberCollection; }
            }

            public static ObservableCollection<Product> ProductCollection
            {
                get { return productCollection; }
            }

            

            public static Product CurrentProduct
            {
                get { return currentProduct; }
            }

            public static Member CurrentMember
            {
                get { return currentMember; }
            }

            
            


            // Static Methods
            // used to add stuff or update stuff in our observalbe list/ collections
            public static void AddProductToCollection(Product product)
            {
                productCollection.Add(product);
            }

            public static void AddMemberToCollection(Member member)
            {
                memberCollection.Add(member);
            }

            public static void UpdateCurrentProduct(Product product)
            {
                currentProduct = product;
            }

            public static void UpdateCurrentMember(Member member)
            {
                currentMember = member;
            }
            
        }
    }
}
    
