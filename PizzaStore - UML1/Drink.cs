using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore___UML1
{
    internal class Drink
    {
        public string? SodaVand { get; set; }

        public decimal Price { get; set; }

        public Drink(string sodavand, decimal price)
        {
            
            SodaVand = sodavand;
            Price = price;
        }

        public override string ToString()
        {
            return ($"{SodaVand}");
        }
    }
}
