using System;

namespace Factory
{
    public class Program
    {
        static void Main(string[] args)
        {
            PizzaStore NYPizzaStore = new NYPizzaStore();
            PizzaStore ChicagoStore = new ChicagoPizzaStore();

            Pizza pizza = NYPizzaStore.OrderPizza("cheese");
            Console.WriteLine($"Yue ordered a {pizza.getName()}");

            pizza = ChicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Larry ordered a {pizza.getName()}");

            NYPizzaStore.OrderPizza("cheese");
        }
    }
}
