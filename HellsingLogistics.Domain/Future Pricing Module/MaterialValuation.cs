namespace HellsingLogistics.Domain.FuturePricingModule;

public class MaterialValuation
{
    public int Id { get; set; }

    public int MaterialId { get; set; }
    public Material Material { get; set; } = null!;

    public decimal BaseValue { get; set; }
    public decimal? QualityMultiplier { get; set; }
    public DateTime EffectiveFromUtc { get; set; } = DateTime.UtcNow;
    public DateTime? EffectiveToUtc { get; set; }
}
