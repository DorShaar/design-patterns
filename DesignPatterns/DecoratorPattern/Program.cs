using DecoratorPattern.After;
using DecoratorPattern.Before;
using System;
using System.Collections.Generic;

namespace MediatorPattern
{
   
    public static class Program
    {
        public static void Main(string[] _)
        {
            RunBefore();

            RunAfter();

            Console.ReadLine();
        }

        private static void RunBefore()
        {
            List<Ingredient> espressoIngredients = new();
            DecoratorPattern.Before.Espresso espresso = new(1.99, espressoIngredients);

            List<Ingredient> macchiatoIngredients = new();
            macchiatoIngredients.Add(new Ingredient("Milk", 1, 1.5));
            macchiatoIngredients.Add(new Ingredient("Sugar", 2, 0.25));
            macchiatoIngredients.Add(new Ingredient("Foam", 1, 0.2));
            DecoratorPattern.Before.Macchiato macchiato = new(2.99, macchiatoIngredients);

            Console.WriteLine($"Total payment: {espresso.Cost + macchiato.Cost}");
        }

        private static void RunAfter()
        {
            DecoratorPattern.After.Espresso espresso = new(1.99);

            DecoratorPattern.After.Coffee macchiato = new DecoratorPattern.After.Espresso(2.99);
            macchiato = new CoffeeWithMilk(macchiato);
            macchiato = new CoffeeWithSugar(macchiato);
            macchiato = new CoffeeWithSugar(macchiato);
            macchiato = new CoffeeWithFoam(macchiato);

            Console.WriteLine($"Total payment: {espresso.Cost + macchiato.Cost}");
        }
    }
}