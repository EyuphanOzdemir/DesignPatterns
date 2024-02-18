using DesignPatternsLibrary.CreationalPatterns.Builder.Products.Enums;
using System.ComponentModel.DataAnnotations;

namespace DesignPatternsLibrary.CreationalPatterns.Builder.Products;

public class House
{
    public House(string name)
    {
        Name = name;
        Parts = [];
    }

    public string Name { get; init; }

    public MaterialType MaterialType { get; set; }

    public List<string> Parts { get; set; }

    public List<string> PartList()
    {
        var result = new List<string>();
        
        result.Add($"{Name} type house will be built");

        result.Add($"House with  {MaterialType} material");
        result.Add($"Parts of the house:");

        foreach ( var part in Parts )
        {
            result.Add(part);
        }
        return result;
    }
}
