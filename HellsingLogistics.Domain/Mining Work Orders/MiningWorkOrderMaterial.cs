namespace HellsingLogistics.Domain.MiningWorkOrders;

public class MiningWorkOrderMaterial
{
    public int Id { get; set; }

    public int MiningWorkOrderId { get; set; }
    public MiningWorkOrder MiningWorkOrder { get; set; } = null!;

    public int MaterialId { get; set; }
    public Material Material { get; set; } = null!;

    public decimal QuantityNeeded { get; set; }
    public int? QualityTargetMin { get; set; }
    public decimal QuantityFulfilled { get; set; }
}
