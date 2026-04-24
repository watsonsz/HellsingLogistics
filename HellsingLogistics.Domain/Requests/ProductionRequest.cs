namespace HellsingLogistics.Domain.Requests;

public class ProductionRequest
{
    public int Id { get; set; }
    public string RequestNumber { get; set; } = string.Empty;

    public int RequesterUserId { get; set; }
    public AppUser RequesterUser { get; set; } = null!;

    public RequestType RequestType { get; set; } = RequestType.Internal;
    public PriorityLevel Priority { get; set; } = PriorityLevel.Normal;
    public RequestStatus Status { get; set; } = RequestStatus.Draft;
    public ReadinessState ReadinessState { get; set; } = ReadinessState.Unknown;

    public bool PricingEnabled { get; set; } = false;
    public string? Notes { get; set; }

    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime? SubmittedAtUtc { get; set; }
    public DateTime? UpdatedAtUtc { get; set; }

    public ICollection<RequestLine> Lines { get; set; } = new List<RequestLine>();
    public ICollection<RequestNote> RequestNotes { get; set; } = new List<RequestNote>();
    public ICollection<RequestStatusHistory> StatusHistory { get; set; } = new List<RequestStatusHistory>();
    public ICollection<ApprovalDecision> ApprovalDecisions { get; set; } = new List<ApprovalDecision>();
    public ICollection<MaterialReservation> MaterialReservations { get; set; } = new List<MaterialReservation>();
    public ICollection<MaterialShortage> MaterialShortages { get; set; } = new List<MaterialShortage>();
    public ICollection<ProductionWorkOrder> ProductionWorkOrders { get; set; } = new List<ProductionWorkOrder>();
    public ICollection<MiningWorkOrder> MiningWorkOrders { get; set; } = new List<MiningWorkOrder>();
    public ICollection<QuoteSnapshot> QuoteSnapshots { get; set; } = new List<QuoteSnapshot>();
    public DeliveryRecord? DeliveryRecord { get; set; }

}