namespace Decorator
{
    public class Whip : CondimentDecorator
    {
        Beverage beverage;
        
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double Cost()
        {
            return .9 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return $"{beverage.GetDescription()}, Whip";
        }
    }
}
