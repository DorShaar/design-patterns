# Decorator Pattern

## Problem
How should I add or remove a responsibility to and object dynamically at run time?
Subclassing is a way to add responsibility, but the responsibility is added at compile time. Therefore the decorator
pattern is a flexible alternative way to subclass for extending functionality.

## Concrete Problem:
We are managing coffee shop, we sell different types of coffees. Each coffee is a different combination of sugar, cream and milk.
I would like to build a coffee system as much flexible as I can.
Each coffee can be pre written with it's own combination of ingredients, but that way we decide in compile time what are the ingredients
of each coffee. In that state, when I want to add new type of coffee, I need to create another instance beside Moccachino and Espresso, 
let's say Long Macchiato, with the approporiate ingrediants.

# How:
Decorator means "Something that decorates". With the decorator pattern I don't need to create those coffee types in advance
It will allow me to add (decorate) the ingredients I like to my cup, creatingin run time my desired coffee.