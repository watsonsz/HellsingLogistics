namespace HellsingLogistics.Domain.BluePrints;

public class Material
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Category { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    public ICollection<BlueprintMaterialRequirement> BlueprintRequirements { get; set; } = new List<BlueprintMaterialRequirement>();
    public ICollection<InventoryBatch> InventoryBatches { get; set; } = new List<InventoryBatch>();
    public ICollection<InventoryTransaction> InventoryTransactions { get; set; } = new List<InventoryTransaction>();
    public ICollection<MaterialReservation> MaterialReservations { get; set; } = new List<MaterialReservation>();
    public ICollection<MaterialShortage> MaterialShortages { get; set; } = new List<MaterialShortage>();
    public ICollection<MiningWorkOrderMaterial> MiningWorkOrderMaterials { get; set; } = new List<MiningWorkOrderMaterial>();
    public ICollection<MaterialValuation> MaterialValuations { get; set; } = new List<MaterialValuation>();
}

