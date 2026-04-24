namespace HellsingLogistics.Domain.BluePrints;

public class Blueprint
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int? BlueprintCategoryId { get; set; }
    public BlueprintCategory? Category { get; set; }
    public string? Subcategory { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    public ICollection<BlueprintMaterialRequirement> MaterialRequirements { get; set; } = new List<BlueprintMaterialRequirement>();
    public ICollection<RequestLine> RequestLines { get; set; } = new List<RequestLine>();
}
