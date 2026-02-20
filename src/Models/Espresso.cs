using DesignPatternChallenge.Contracts;

namespace DesignPatternChallenge.Models;

public class Espresso: ICoffe
{
    public decimal GetCost() => 3.50m;
    public string GetDescription() => "Espresso";
}