namespace HellsingLogistics.Domain.Inventory;

public class MaterialShortage
{
    public int Id { get; set; }

    public int ProductionRequestId { get; set; }
    public ProductionRequest ProductionRequest { get; set; } = null!;

    public int? RequestLineId { get; set; }
    public RequestLine? RequestLine { get; set; }

    public int MaterialId { get; set; }
    public Material Material { get; set; } = null!;

    public decimal QuantityRequired { get; set; }
    public decimal QuantityAvailableAtCheck { get; set; }
    public decimal QuantityShort { get; set; }
    public decimal QuantityFulfilled { get; set; }
    public int? QualityTargetMin { get; set; }
    public bool IsResolved { get; set; }

    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime? ResolvedAtUtc { get; set; }
}
