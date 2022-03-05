namespace DecoratorPattern.After
{
    internal class CoffeeWithFoam : CoffeeDecorator
    {
        public Coffee Coffee { get; }

        public override double Cost => Coffee.Cost + 0.2;

        public override string Description => Coffee.Description;

        public CoffeeWithFoam(Coffee coffee)
        {
            Coffee = coffee;
        }
    }
}