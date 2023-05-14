using Midterm2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    abstract class Drink : Product
    {
        // Fields
        public enum Size { Short, Tall, Grande, Venti, Trenta };

        
        

        // Constructor gets the name, price, points, and size of the drink.
        public Drink(string name, double price, int points, Size drinkSize) : base(name, price, points)
        {
           
        }

        // Properties
        public Size DrinkSize { get { return DrinkSize; } }
    }

}
