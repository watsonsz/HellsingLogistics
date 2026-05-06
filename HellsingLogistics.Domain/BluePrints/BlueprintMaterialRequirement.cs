using System.ComponentModel.DataAnnotations.Schema;
using HellsingLogistics.Domain.Common;

namespace HellsingLogistics.Domain.BluePrints;

public class BlueprintMaterialRequirement :BaseEntity
{
    public Guid BlueprintId { get; set; }

    [ForeignKey(nameof(MaterialId))]
    public Guid MaterialId { get; set; }
    public Material Material { get; set; } = null!;

    public decimal QuantityPerUnit { get; set; }
    public int? DefaultQualityMin { get; set; }
}
