namespace HellsingLogistics.Domain.BluePrints;

public class BlueprintCategory
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int? ParentCategoryId { get; set; }
    public BlueprintCategory? ParentCategory { get; set; }

    public ICollection<BlueprintCategory> Children { get; set; } = new List<BlueprintCategory>();
    public ICollection<Blueprint> Blueprints { get; set; } = new List<Blueprint>();
}
