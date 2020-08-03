namespace Decorator
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            _description = "Dark Roast";
        }
        public override double Cost()
        {
            return 2.15;
        }
    }
}
