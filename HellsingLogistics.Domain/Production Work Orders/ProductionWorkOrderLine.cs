namespace HellsingLogistics.Domain.ProductionWorkOrders;

public class ProductionWorkOrderLine
{
    public int Id { get; set; }

    public int ProductionWorkOrderId { get; set; }
    public ProductionWorkOrder ProductionWorkOrder { get; set; } = null!;

    public int RequestLineId { get; set; }
    public RequestLine RequestLine { get; set; } = null!;

    public int BlueprintId { get; set; }
    public Blueprint Blueprint { get; set; } = null!;

    public int Quantity { get; set; }
    public WorkOrderStatus Status { get; set; } = WorkOrderStatus.Open;
}
