using System.Collections.Generic;

namespace DecoratorPattern.Before
{
    internal abstract class Coffee
    {
        public abstract double Cost { get; }
        public abstract string Description { get; }
        protected abstract List<Ingredient> Ingredients { get; }
        protected double calculateIngredientsCost()
        {
            double sum = 0;
            foreach (Ingredient ingredient in Ingredients)
            {
                sum += (ingredient.Amount * ingredient.Cost);
            }

            return sum;
        }
    }
}