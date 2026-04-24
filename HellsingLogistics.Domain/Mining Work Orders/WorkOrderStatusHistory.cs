namespace HellsingLogistics.Domain.MiningWorkOrders;

public class WorkOrderStatusHistory
{
    public int Id { get; set; }

    public int? ProductionWorkOrderId { get; set; }
    public ProductionWorkOrder? ProductionWorkOrder { get; set; }

    public int? MiningWorkOrderId { get; set; }
    public MiningWorkOrder? MiningWorkOrder { get; set; }

    public WorkOrderStatus? OldStatus { get; set; }
    public WorkOrderStatus NewStatus { get; set; }

    public int ChangedByUserId { get; set; }
    public AppUser ChangedByUser { get; set; } = null!;

    public DateTime ChangedAtUtc { get; set; } = DateTime.UtcNow;
    public string? Note { get; set; }
}
