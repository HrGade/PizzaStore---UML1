﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore___UML1
{
    internal class Customer
    {
        public string Name { get; set; 


        public Customer(string name)
        {
            Name = name;
              
        }
        public override string ToString()
        {
            return ($"Kundenavn {Name}");
        }
    }
}
