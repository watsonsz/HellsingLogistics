using HellsingLogistics.Domain.Common;

namespace HellsingLogistics.Domain.ProductionWorkOrders;

public class ProductionWorkOrder: BaseEntity
{   
    public ProductionWorkOrder()
    {
        WorkOrderNumber = $"PROD-{DateTime.Now.ToString("yyyyMMddHHmmss")}";
    }

    public string WorkOrderNumber { get; set; }

    public int ProductionRequestId { get; set; }
    public ProductionRequest ProductionRequest { get; set; } = null!;

    public WorkOrderStatus Status { get; set; } = WorkOrderStatus.Open;
    public PriorityLevel Priority { get; set; } = PriorityLevel.Normal;

    public int? AssignedToUserId { get; set; }

    public DateTime? StartedAtUtc { get; set; }
    public DateTime? CompletedAtUtc { get; set; }

    public string? Notes { get; set; }

    public ICollection<ProductionWorkOrderLine> Lines { get; set; } = new List<ProductionWorkOrderLine>();
    public ICollection<WorkOrderStatusHistory> StatusHistory { get; set; } = new List<WorkOrderStatusHistory>();
}
