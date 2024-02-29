using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore___UML1
{
    internal class Order
    {
        public  Pizza Pizza { get; set; }
        public Customer Customer { get; set; }
        public Drink Drink { get; set; }

        //Constructor for Order
        public Order(Pizza pizza, Customer customer, Drink drink) 
        { 
            Pizza = pizza;
            Customer = customer;
            Drink = drink;  
        }
        /*Method for calculation of the prize of a menu*/
        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = Pizza.Price + Drink.Price;  
            totalPrice *= 1.25m; //Adding tax money
            return totalPrice;
        }

        public override string ToString()
        {
            decimal totalPrice = CalculateTotalPrice();
            return ($"Order: 1 stk. {Pizza.Name}, 1 stk. {Drink}, For {Customer}, Pris: {totalPrice}kr.");
        }

        

    }
}
