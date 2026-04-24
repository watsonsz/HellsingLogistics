public class InventoryTransaction
{
    public int Id { get; set; }

    public int MaterialId { get; set; }
    public Material Material { get; set; } = null!;

    public int? InventoryBatchId { get; set; }
    public InventoryBatch? InventoryBatch { get; set; }

    public InventoryTransactionType TransactionType { get; set; }
    public decimal Quantity { get; set; }
    public int? QualityValue { get; set; }

    public string? RelatedEntityType { get; set; }
    public int? RelatedEntityId { get; set; }

    public int CreatedByUserId { get; set; }
    public AppUser CreatedByUser { get; set; } = null!;

    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public string? Notes { get; set; }
}
