public class MaterialReservation
{
    public int Id { get; set; }

    public int ProductionRequestId { get; set; }
    public ProductionRequest ProductionRequest { get; set; } = null!;

    public int? RequestLineId { get; set; }
    public RequestLine? RequestLine { get; set; }

    public int MaterialId { get; set; }
    public Material Material { get; set; } = null!;

    public int InventoryBatchId { get; set; }
    public InventoryBatch InventoryBatch { get; set; } = null!;

    public decimal QuantityReserved { get; set; }
    public ReservationStatus Status { get; set; } = ReservationStatus.Active;

    public DateTime ReservedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime? ReleasedAtUtc { get; set; }
    public DateTime? ConsumedAtUtc { get; set; }
}