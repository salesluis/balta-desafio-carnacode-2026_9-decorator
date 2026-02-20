using DesignPatternChallenge.Contracts;
using DesignPatternChallenge.Decorator;

namespace DesignPatternChallenge.DecoratorConcrete;

public class Chocolate(ICoffe coffe) : CoffeDecorator(coffe)
{
    public override decimal GetCost() => Coffe.GetCost() + 0.70m;
    public override string GetDescription() =>  Coffe.GetDescription() + ", Chocolate";
}