using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore___UML1
{
    internal class Menu
    {
        public void CustomerOrder() { 
        //Create Pizzas
        Pizza pizza1 = new Pizza("Margherita", 35);
        Pizza pizza2 = new Pizza("GreekPizza", 65);
        Pizza pizza3 = new Pizza("SalatPizza", 55); 

        //Create Drinks
        Drink pepsi = new Drink("Pepsi", 30);
        Drink cola = new Drink("Cola", 30);
        Drink fanta = new Drink("Fanta", 30);

        //Create Customers
        Customer customer1 = new Customer("Kundenavn");
        Customer customer2 = new Customer("Kundenavn");
        Customer Customer3 = new Customer("Kundenavn");

        //Create orders
        Order order1 = new Order(pizza1, customer1, pepsi);
        Order order2 = new Order(pizza2, customer2, cola);
        Order order3 = new Order(pizza3, Customer3, fanta);

            int nr1 = 1;
            nr1 = int.Parse(Console.ReadLine()!);

            if (nr1 == 1) 
            {
                Console.WriteLine(order1);
            }

            
            if (nr1 == 2)
            {
                Console.WriteLine(order2);
            }

            
            if (nr1 == 3) 
            {
                Console.WriteLine(order3);
            }
        
        }

    }
}
