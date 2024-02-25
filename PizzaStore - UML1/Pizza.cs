using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore___UML1
{
    internal class Pizza
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        /*Constructor for class "Pizza"*/
        public Pizza(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        /*ToString method to sent the pizza-attributes to the class menu*/
        public override string ToString()
        {
            return ($"Pizza: {Name}, Price: {Price}");
        }
    }
}
