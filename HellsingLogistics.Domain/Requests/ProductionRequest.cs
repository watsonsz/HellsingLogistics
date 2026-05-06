using System.ComponentModel.DataAnnotations.Schema;
using HellsingLogistics.Domain.BluePrints;
using HellsingLogistics.Domain.Common;

namespace HellsingLogistics.Domain.Requests;

public class ProductionRequest: BaseEntity
{
    public ProductionRequest()
    {
        RequestNumber = $"REQ-{DateTime.Now.ToString("yyyyMMddHHmmss")}";
    }
    public string RequestNumber { get; set; } = string.Empty;

    //TODO: REFERENCE USER, USER SHOULD HAVE INTERNAL OR EXTERNAL DESIGNATION
    public RequestType RequestType { get; set; }//= User.Orgmember;
    public PriorityLevel Priority { get; set; } = PriorityLevel.Normal;
    public RequestStatus Status { get; set; } = RequestStatus.Draft;
    public ReadinessState ReadinessState { get; set; } = ReadinessState.Unknown;

    [ForeignKey(nameof(BlueprintId))]
    public Guid BlueprintId { get; set; }
    public Blueprint Blueprint {get; set;}
    public bool PricingEnabled { get; set; } = false;

}