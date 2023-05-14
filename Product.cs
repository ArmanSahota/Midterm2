using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{

    public abstract class Product
    {
        public string Name { get; set; }
        public int Sku { get; set; }
        public double Price { get; set; }
        public int Points { get; set; }
        public static int NumberOfProducts { get; set; }

        public Product(string name, double price, int points)
        {
            Name = name;
            Price = price;
            Points = points;

            // Use a random object to assign a value to sku between 1000000 and 10000000
            Random rnd = new Random();
            Sku = rnd.Next(1000000, 10000000);

            // Increment the number of products
            NumberOfProducts++;
        }
        // displays the products name, price, points, and the product id.
        public override string ToString()
        {
            return "Name:  " + Name + " Price: $ " + Price + " Points: "+ Points + "ProductID: " + Sku ;
        }
    }
}
