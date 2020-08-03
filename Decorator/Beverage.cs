namespace Decorator
{
    public abstract class Beverage
    {
        protected string _description = "Unknow Beverage";
        public string GetDescription()
        {
            return _description;
        }

        public abstract double Cost();
        
    }
}
