using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class Pizza
    {
        public void Prepare()
        {
            Console.WriteLine("I am preparing...");
        }
        public void Bake()
        {
            Console.WriteLine("I am baking...");
        }
        public void Cut()
        {
            Console.WriteLine("I am cutting...");
        }
        public void Box()
        {
            Console.WriteLine("I am boxing...");
        }
    }
}
