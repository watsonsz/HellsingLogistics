namespace HellsingLogistics.Domain.Delivery;

public class PickupLocation
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? SystemName { get; set; }
    public string? PlanetOrMoon { get; set; }
    public string? StationOrOutpost { get; set; }
    public string? Notes { get; set; }
    public bool IsActive { get; set; } = true;

    public ICollection<DeliveryRecord> DeliveryRecords { get; set; } = new List<DeliveryRecord>();
}
