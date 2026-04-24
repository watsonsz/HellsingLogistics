namespace HellsingLogistics.Domain.FuturePricingModule;

public class PricingProfile
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool IsEnabled { get; set; }
    public decimal MarkupPercent { get; set; }
    public decimal FlatProductionFee { get; set; }
    public string? Notes { get; set; }
}
