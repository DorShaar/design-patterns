namespace DecoratorPattern.After
{
    internal class CoffeeWithMilk : CoffeeDecorator
    {
        public Coffee Coffee { get; }

        public override double Cost => Coffee.Cost + 1.5;

        public override string Description => Coffee.Description;

        public CoffeeWithMilk(Coffee coffee)
        {
            Coffee = coffee;
        }
    }
}