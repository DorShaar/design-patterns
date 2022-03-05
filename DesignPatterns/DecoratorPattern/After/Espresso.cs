namespace DecoratorPattern.After
{
    internal class Espresso : Coffee
    {
        public override string Description => "Espresso";

        public override double Cost { get; }

        public Espresso(double baseCost)
        {
            Cost = baseCost;
        }
    }
}