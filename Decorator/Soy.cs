﻿namespace Decorator
{
    public class Soy : CondimentDecorator
    {
        Beverage beverage;
        
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double Cost()
        {
            return 0.5 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return $"{beverage.GetDescription()}, Soy";
        }
    }
}
