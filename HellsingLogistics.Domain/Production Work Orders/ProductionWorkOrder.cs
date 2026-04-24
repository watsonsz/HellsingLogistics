namespace HellsingLogistics.Domain.ProductionWorkOrders;

public class ProductionWorkOrder
{
    public int Id { get; set; }
    public string WorkOrderNumber { get; set; } = string.Empty;

    public int ProductionRequestId { get; set; }
    public ProductionRequest ProductionRequest { get; set; } = null!;

    public WorkOrderStatus Status { get; set; } = WorkOrderStatus.Open;
    public PriorityLevel Priority { get; set; } = PriorityLevel.Normal;

    public int? AssignedToUserId { get; set; }
    public AppUser? AssignedToUser { get; set; }

    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime? StartedAtUtc { get; set; }
    public DateTime? CompletedAtUtc { get; set; }

    public string? Notes { get; set; }

    public ICollection<ProductionWorkOrderLine> Lines { get; set; } = new List<ProductionWorkOrderLine>();
    public ICollection<WorkOrderStatusHistory> StatusHistory { get; set; } = new List<WorkOrderStatusHistory>();
}
