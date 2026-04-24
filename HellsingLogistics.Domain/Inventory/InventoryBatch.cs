namespace HellsingLogistics.Domain.Inventory;

public class InventoryBatch
{
    public int Id { get; set; }

    public int MaterialId { get; set; }
    public Material Material { get; set; } = null!;

    public InventorySourceType SourceType { get; set; } = InventorySourceType.ManualEntry;
    public string? SourceReference { get; set; }

    public decimal QuantityReceived { get; set; }
    public decimal QuantityAvailable { get; set; }
    public decimal QuantityReserved { get; set; }
    public decimal QuantityConsumed { get; set; }

    public int QualityValue { get; set; }
    public QualityBand QualityBand { get; set; } = QualityBand.Unknown;

    public DateTime ReceivedAtUtc { get; set; } = DateTime.UtcNow;
    public string? Notes { get; set; }

    public ICollection<InventoryTransaction> Transactions { get; set; } = new List<InventoryTransaction>();
    public ICollection<MaterialReservation> Reservations { get; set; } = new List<MaterialReservation>();
}
