using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            _name = "Chicago Style Deep Dish Cheese Pizza";
            _dough = "Extra Thick Crust Dough";
            _sauce = "Plum Tomato Sauce";
        }

        void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
