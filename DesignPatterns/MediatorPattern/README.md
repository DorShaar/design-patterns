# Mediator Pattern

Also known as: Intermediary or Controller.

## Problem
We have a program with two classes, A and B, while B is dependant at A. We would like to reduce such
dependancy since we would like to get a modular program that let me replace, as part of application maintenance, easily,
without preserving existing dependancy. 

## Concrete Problem:
We have few computer colleagues that we would like to report each other who has been registered to the system.
In order to implement it without that pattern, we had to make a dependency between those computers that will let
each other know who just registered or unregistered from the system. That dependancy may harm our application maintenance.

## How:
The Mediator pattern enables objects to communicate, without knowing each other’s identities.
You can think of a Mediator object as a kind of a coordinator, that handles traffic between appropriate parties based on its own logic.

The mediator "stands in the center" of each object and holds a list of all registered computers and sends them a notification
in case another computer has registered or unregistered. In that sample, it actually does not hold a list of IColleagues but
a delegate (list of methods) which each method is related to the already registered IColleagues.