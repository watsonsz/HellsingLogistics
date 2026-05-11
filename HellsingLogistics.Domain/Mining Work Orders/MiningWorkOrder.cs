using System.ComponentModel.DataAnnotations.Schema;
using HellsingLogistics.Domain.Common;

namespace HellsingLogistics.Domain.MiningWorkOrders;

public class MiningWorkOrder : BaseEntity
{
    public MiningWorkOrder ()
    {
        
        WorkOrderNumber = $"MWO-{DateTime.Now.ToString("yyyyMMddHHmmss")}";

    }

    public String WorkOrderNumber { get; set; }
    
    public WorkOrderStatus Status { get; set; } = WorkOrderStatus.Open;
    
    public PriorityLevel Priority { get; set; } = PriorityLevel.Normal;
 
    public DateTime? CompletedAtUtc { get; set; }
    
    public ICollection<MiningWorkOrderMaterial> MaterialsNeeded { get; set; } = new List<MiningWorkOrderMaterial>();
}


