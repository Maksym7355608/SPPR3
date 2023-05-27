namespace SPPR3;

public class ParetoOptimization
{
    public List<House> FindParetoSet(List<House> houses)
    {
        return (from house in houses 
            let isDominated = 
                houses.Any(otherHouse => 
                    (otherHouse.Price <= house.Price && 
                     otherHouse.Size >= house.Size && 
                     otherHouse.Condition >= house.Condition && 
                     otherHouse.DistanceToCityCenter >= house.DistanceToCityCenter) && 
                    (otherHouse.Price < house.Price || otherHouse.Size > house.Size || 
                     otherHouse.Condition > house.Condition || otherHouse.DistanceToCityCenter > house.DistanceToCityCenter)) 
            where !isDominated select house).ToList();
    }
}