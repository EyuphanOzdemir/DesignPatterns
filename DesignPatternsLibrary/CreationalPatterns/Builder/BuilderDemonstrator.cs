using CustomSandwichBuilder.Builders;
using CustomSandwichBuilder.Directors;
using DesignPatternsLibrary.CreationalPatterns.Builder.Builders;

namespace DesignPatternsLibrary.CreationalPatterns.Builder
{
    public class BuilderDemonstrator : IPatternDemonstrator
    {
        public string Demonstrate(params string[] parameters)
        {
            var houseType = parameters[0];
            IHouseBuilder houseBuilder = houseType == "Cheap" ? new CheapHouseBuilder() : new RichHouseBuilder();
            //we can use directly builders...
            //houseBuilder.BuildGarden();
            //houseBuilder.BuildGarage();
            //etc.
            //var house = houseBuilder.GetHouse();
            
            //or we can use a director by passing the builder to it
            //director can decide what to do in which order
            var director = new HouseDirector(houseBuilder);
            director.MakeHouse();
            var house = director.GetHouse();
            return String.Join(Environment.NewLine, house.PartList());
        }
    }
}
