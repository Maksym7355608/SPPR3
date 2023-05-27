// Приклад вхідних даних

using SPPR3;

var houses = new List<House>
{
    new() { Id = "A1", Price = (int)EPrice.Cheap, Size = (int)ESize.Big, Condition = (int)ECondition.NeedCapitalRepair, DistanceToCityCenter = (int)EDistance.OutCity },
    new()  { Id = "A2", Price = (int)EPrice.Expensive, Size = (int)ESize.Small, Condition = (int)ECondition.NeedMinimalRepair, DistanceToCityCenter = (int)EDistance.Near },
    new()  { Id = "A3", Price = (int)EPrice.Cheap, Size = (int)ESize.Medium, Condition = (int)ECondition.NeedMinimalRepair, DistanceToCityCenter = (int)EDistance.InCenter },
    new()  { Id = "A4", Price = (int)EPrice.Cheap, Size = (int)ESize.Small, Condition = (int)ECondition.NeedCapitalRepair, DistanceToCityCenter = (int)EDistance.OutCity },
    new()  { Id = "A5", Price = (int)EPrice.Expensive, Size = (int)ESize.Big, Condition = (int)ECondition.EuroRepair, DistanceToCityCenter = (int)EDistance.InCenter },
    new()  { Id = "A6", Price = (int)EPrice.Cheap, Size = (int)ESize.Small, Condition = (int)ECondition.EuroRepair, DistanceToCityCenter = (int)EDistance.Far },
    new()  { Id = "A7", Price = (int)EPrice.Expensive, Size = (int)ESize.Medium, Condition = (int)ECondition.EuroRepair, DistanceToCityCenter = (int)EDistance.OutCity },
    new()  { Id = "A8", Price = (int)EPrice.Cheap, Size = (int)ESize.Medium, Condition = (int)ECondition.EuroRepair, DistanceToCityCenter = (int)EDistance.Far },
    new()  { Id = "A9", Price = (int)EPrice.Cheap, Size = (int)ESize.Small, Condition = (int)ECondition.NeedCapitalRepair, DistanceToCityCenter = (int)EDistance.OutCity },
    new()  { Id = "A10", Price = (int)EPrice.Cheap, Size = (int)ESize.Small, Condition = (int)ECondition.NeedCapitalRepair, DistanceToCityCenter = (int)EDistance.Near },
};

var paretoOptimization = new ParetoOptimization();
var paretoSet = paretoOptimization.FindParetoSet(houses);

Console.WriteLine("Pareto Set:");
foreach (var house in paretoSet)
{
    Console.WriteLine($"House Id: {house.Id}, Price: {((EPrice)house.Price).GetDescription()}, Size: {((ESize)house.Size).GetDescription()}, Condition: {((ECondition)house.Condition).GetDescription()}, DistanceToCityCenter: {((EDistance)house.DistanceToCityCenter).GetDescription()}");
}
