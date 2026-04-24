namespace HellsingLogistics.Domain.Delivery;

public class DeliveryRecord
{
    public int Id { get; set; }

    public int ProductionRequestId { get; set; }
    public ProductionRequest ProductionRequest { get; set; } = null!;

    public DeliveryStatus Status { get; set; } = DeliveryStatus.NotReady;

    public int? PickupLocationId { get; set; }
    public PickupLocation? PickupLocation { get; set; }

    public int? DeliveredByUserId { get; set; }
    public AppUser? DeliveredByUser { get; set; }

    public string? RecipientName { get; set; }
    public DateTime? ReadyAtUtc { get; set; }
    public DateTime? DeliveredAtUtc { get; set; }
    public string? Notes { get; set; }
}
