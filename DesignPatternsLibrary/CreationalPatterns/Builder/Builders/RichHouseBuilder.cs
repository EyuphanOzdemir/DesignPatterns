using DesignPatternsLibrary.CreationalPatterns.Builder.Builders;
using DesignPatternsLibrary.CreationalPatterns.Builder.Products.Enums;
using DesignPatternsLibrary.CreationalPatterns.Builder.Products;

namespace CustomSandwichBuilder.Builders;

public class RichHouseBuilder : IHouseBuilder
{
    private readonly House _house;

    public RichHouseBuilder() => _house = new House("Rich");
    public void BuildRoof()
    {
        _house.Parts.Add("Rich Roof");
    }

    public void BuildGarden()
    {
        _house.Parts.Add("Rich Garden");
    }

    public void BuildWindows()
    {
        _house.Parts.Add("Rich Windows");
    }

    public void BuildRooms()
    {
        _house.Parts.Add("Rich Rooms");
    }

    public void BuildGarage()
    {
        _house.Parts.Add("Rich Garage");
    }

    public void BuildDoors()
    {
        _house.Parts.Add("Rich Doors");
    }

    public void Reset()
    {
        _house.MaterialType = MaterialType.Concrete;
        _house.Parts.Clear();
    }

    public House GetHouse()
    {
        return _house;
    }
}

