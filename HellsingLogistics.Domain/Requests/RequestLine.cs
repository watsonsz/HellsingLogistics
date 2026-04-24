namespace HellsingLogistics.Domain.Requests;

public class RequestLine
{
    public int Id { get; set; }

    public int ProductionRequestId { get; set; }
    public ProductionRequest ProductionRequest { get; set; } = null!;

    public int BlueprintId { get; set; }
    public Blueprint Blueprint { get; set; } = null!;

    public int Quantity { get; set; }
    public int? DesiredQualityMin { get; set; }

    public RequestLineStatus Status { get; set; } = RequestLineStatus.Pending;
    public ReadinessState ReadinessState { get; set; } = ReadinessState.Unknown;

    public string? Notes { get; set; }

    public ICollection<MaterialReservation> MaterialReservations { get; set; } = new List<MaterialReservation>();
    public ICollection<ProductionWorkOrderLine> ProductionWorkOrderLines { get; set; } = new List<ProductionWorkOrderLine>();
}
