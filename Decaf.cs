namespace Decorator
{
    internal class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf";
        }
        public override double Cost() => 1.49;
    }
}
