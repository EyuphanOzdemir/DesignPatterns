using DesignPatternsLibrary.CreationalPatterns.Builder.Products;

namespace DesignPatternsLibrary.CreationalPatterns.Builder.Builders;

public interface IHouseBuilder
{
    void Reset();
    House GetHouse();
    void BuildWindows();
    void BuildRooms();

    void BuildRoof();

    void BuildDoors();

    void BuildGarden();

    void BuildGarage();
}
