namespace DecoratorPattern.After
{
    internal class CoffeeWithSugar : CoffeeDecorator
    {
        public Coffee Coffee { get; }

        public override double Cost => Coffee.Cost + 0.25;

        public override string Description => Coffee.Description;

        public CoffeeWithSugar(Coffee coffee)
        {
            Coffee = coffee;
        }
    }
}