namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage1 = new Mocha(new Espresso()); //Espresso, Mocha
            Beverage beverage2 = new Mocha(new Decaf());    //Decaf, Mocha
            Beverage beverage3 = new WhipedMilk(new Mocha(new Decaf()));    //Decaf, Mocha, WhipedMilk
            
            Console.WriteLine($"beverage1: {beverage1.Description} and it costs {beverage1.Cost()} $");
            Console.WriteLine($"beverage2: {beverage2.Description} and it costs {beverage2.Cost()} $");
            Console.WriteLine($"beverage3: {beverage3.Description} and it costs {beverage3.Cost()} $");
        }
    }
}