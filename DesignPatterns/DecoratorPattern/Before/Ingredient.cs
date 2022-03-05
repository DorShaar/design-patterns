namespace DecoratorPattern.Before
{
    internal class Ingredient
    {
        public string Name { get; init; }
        public int Amount { get; init; }
        public double Cost { get; init; }

        public Ingredient(string name, int amount, double cost)
        {
            Name = name;
            Amount = amount;
            Cost = cost;
        }
    }
}