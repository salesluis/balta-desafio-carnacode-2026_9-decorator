using DesignPatternChallenge.Contracts;

namespace DesignPatternChallenge.Decorator;

public abstract class CoffeDecorator(ICoffe coffe) : ICoffe
{
    protected readonly ICoffe Coffe = coffe;
    
    public virtual decimal GetCost() => Coffe.GetCost();

    public virtual string GetDescription() =>  Coffe.GetDescription();
}