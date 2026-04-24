namespace HellsingLogistics.Domain.BluePrints;

public class BlueprintMaterialRequirement
{
    public int Id { get; set; }

    public int BlueprintId { get; set; }
    public Blueprint Blueprint { get; set; } = null!;

    public int MaterialId { get; set; }
    public Material Material { get; set; } = null!;

    public decimal QuantityPerUnit { get; set; }
    public int? DefaultQualityMin { get; set; }
}
