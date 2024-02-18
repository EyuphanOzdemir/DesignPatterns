using DesignPatternsLibrary.CreationalPatterns.Builder.Builders;
using DesignPatternsLibrary.CreationalPatterns.Builder.Products;
using DesignPatternsLibrary.CreationalPatterns.Builder.Products.Enums;

namespace CustomSandwichBuilder.Builders;

public class CheapHouseBuilder : IHouseBuilder
{
    private readonly House _house;

    public CheapHouseBuilder() => _house = new House("Cheap");
    public void BuildRoof()
    {
        _house.Parts.Add("Cheap Roof");
    }

    public void BuildGarden()
    {
        _house.Parts.Add("Cheap Garden");
    }

    public void BuildWindows()
    {
        _house.Parts.Add("Cheap Windows");
    }

    public void BuildRooms()
    {
        _house.Parts.Add("Cheap Rooms");
    }

    public void BuildGarage()
    {
        _house.Parts.Add("Cheap Garage");
    }

    public void BuildDoors()
    {
        _house.Parts.Add("Cheap Doors");
    }

    public void Reset()
    {
        _house.MaterialType = MaterialType.Prefabric;
        _house.Parts.Clear();
    }

    public House GetHouse()
    {
        return _house;
    }
}
