using DesignPatternsLibrary.CreationalPatterns.Builder.Builders;
using DesignPatternsLibrary.CreationalPatterns.Builder.Products;
namespace CustomSandwichBuilder.Directors;

public class HouseDirector(IHouseBuilder builder)
{
    private IHouseBuilder _builder = builder;

    public void ChangeBuilder(IHouseBuilder newBuilder) => _builder = newBuilder;

    public void MakeHouse()
    {
       _builder.Reset();
       _builder.BuildRooms();
       _builder.BuildWindows();
       _builder.BuildGarage();
       _builder.BuildDoors();
       _builder.BuildGarden();
       _builder.BuildRoof();
    }

    public House GetHouse() => _builder.GetHouse();
}
