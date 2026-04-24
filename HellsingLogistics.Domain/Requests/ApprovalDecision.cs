namespace HellsingLogistics.Domain.Requests;
public class ApprovalDecision
{
    public int Id { get; set; }

    public int ProductionRequestId { get; set; }
    public ProductionRequest ProductionRequest { get; set; } = null!;

    public ApprovalDecisionType Decision { get; set; }

    public int DecidedByUserId { get; set; }
    public AppUser DecidedByUser { get; set; } = null!;

    public DateTime DecidedAtUtc { get; set; } = DateTime.UtcNow;
    public string? Note { get; set; }
}
