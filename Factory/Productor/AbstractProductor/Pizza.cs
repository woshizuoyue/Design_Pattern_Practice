using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public abstract class Pizza
    {
        protected string _name;
        protected string _dough;
        protected string _sauce;

        // need a list

        public void Prepare()
        {
            Console.WriteLine($"Preparing, {_name}");
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");

            // need a for loop to get list;

        }
        public void Bake()
        {
            Console.WriteLine("Bake for 25 min at 350");
        }
        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
        public string getName()
        {
            return _name;
        }
    }
}
