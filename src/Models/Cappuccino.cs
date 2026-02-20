using DesignPatternChallenge.Contracts;

namespace DesignPatternChallenge.Models;

public class Cappuccino : ICoffe
{
    public decimal GetCost() => 4.50m;
    public string GetDescription() => "Cappuccino";
}