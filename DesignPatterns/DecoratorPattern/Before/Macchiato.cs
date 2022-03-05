using System.Collections.Generic;

namespace DecoratorPattern.Before
{
    internal class Macchiato : Coffee
    {
        public override double Cost => baseCost + calculateIngredientsCost();
        public override string Description => "Macchiato";

        protected override List<Ingredient> Ingredients { get; }

        private readonly double baseCost;

        public Macchiato(double baseCost, List<Ingredient> ingredients)
        {
            Ingredients = ingredients;
            this.baseCost = baseCost;
        }
    }
}