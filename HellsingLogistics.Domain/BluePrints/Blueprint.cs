using System.ComponentModel.DataAnnotations.Schema;
using HellsingLogistics.Domain.Common;

namespace HellsingLogistics.Domain.BluePrints;

// Rember the Open/Close Principle: Classes are open to extension, but closed to modification
public class Blueprint : BaseEntity
{
    public string Name { get; set; }

    public BlueprintCategory Category { get; set; }

    [ForeignKey(nameof(SubCategoryId))]
    public Guid SubCategoryId {get; set;}
    public BlueprintSubCategory? SubCategory {get; set;}
    public bool IsActive { get; set; } = false;

    public ICollection<BlueprintMaterialRequirement> MaterialRequirements { get; set; } = new List<BlueprintMaterialRequirement>();
}

