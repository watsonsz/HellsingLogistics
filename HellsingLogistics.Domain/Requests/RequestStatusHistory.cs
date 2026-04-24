public class RequestStatusHistory
{
    public int Id { get; set; }

    public int ProductionRequestId { get; set; }
    public ProductionRequest ProductionRequest { get; set; } = null!;

    public RequestStatus? OldStatus { get; set; }
    public RequestStatus NewStatus { get; set; }

    public int ChangedByUserId { get; set; }
    public AppUser ChangedByUser { get; set; } = null!;

    public DateTime ChangedAtUtc { get; set; } = DateTime.UtcNow;
    public string? Note { get; set; }
}
