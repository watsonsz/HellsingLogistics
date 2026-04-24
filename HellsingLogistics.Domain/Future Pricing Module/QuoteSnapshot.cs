namespace HellsingLogistics.Domain.FuturePricingModule;

public class QuoteSnapshot
{
    public int Id { get; set; }

    public int ProductionRequestId { get; set; }
    public ProductionRequest ProductionRequest { get; set; } = null!;

    public decimal MaterialSubtotal { get; set; }
    public decimal ProductionSubtotal { get; set; }
    public decimal MarkupAmount { get; set; }
    public decimal FinalTotal { get; set; }
    public bool WasManuallyOverridden { get; set; }
    public string? OverrideReason { get; set; }

    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
}
