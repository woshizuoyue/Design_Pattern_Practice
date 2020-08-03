namespace Decorator
{
    public class Decat : Beverage
    {
        public Decat()
        {
            _description = "Decat";
        }

        public override double Cost()
        {
            return 2.45;
        }
    }
}
