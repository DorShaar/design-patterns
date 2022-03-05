using System.Collections.Generic;

namespace DecoratorPattern.Before
{
    internal class Espresso : Coffee
    {
        public override double Cost => baseCost + calculateIngredientsCost();
        public override string Description => "Espresso";

        protected override List<Ingredient> Ingredients { get; }

        private readonly double baseCost;

        public Espresso(double baseCost, List<Ingredient> ingredients)
        {
            Ingredients = ingredients;
            this.baseCost = baseCost;
        }
    }
}