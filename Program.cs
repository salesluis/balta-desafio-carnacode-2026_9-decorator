
using DesignPatternChallenge.DecoratorConcrete;
using DesignPatternChallenge.Models;

Console.WriteLine("=== Sistema de Pedidos - Cafeteria ===\n");

Console.WriteLine("--- Pedidos com classes decoradoras ---");

var espresso = new Espresso();
Console.WriteLine($"{espresso.GetDescription()}: R$ {espresso.GetCost():N2}");

var espressoComLeite = new Leite(espresso);
Console.WriteLine($"{espressoComLeite.GetDescription()}: R$ {espressoComLeite.GetCost():N2}");

var espressoComLeiteEChocolate = new Chocolate(espressoComLeite);
Console.WriteLine($"{espressoComLeiteEChocolate.GetDescription()}: R$ {espressoComLeiteEChocolate.GetCost():N2}");

// E se o cliente quiser Espresso com Leite, Chocolate, Chantilly e Caramelo?
// É só fazer a composição com o objeto desejado!

// Perguntas para reflexão:
// - Como adicionar comportamento a um objeto dinamicamente? -> criando classes que imprementam o CoffeDecorator
// - Como combinar múltiplos comportamentos sem criar classes para cada combinação? -> Através da composição dos objetos decorator

