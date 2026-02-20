using DesignPatternChallenge.Contracts;
using DesignPatternChallenge.Decorator;

namespace DesignPatternChallenge.DecoratorConcrete;

public class Chantilly(ICoffe coffe) : CoffeDecorator(coffe)
{
    public override decimal GetCost() => Coffe.GetCost() + 1.00m;
    public override string GetDescription() =>  Coffe.GetDescription() + ", Chantilly";
}