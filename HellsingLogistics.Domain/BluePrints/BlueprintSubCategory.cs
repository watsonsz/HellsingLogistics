using System.ComponentModel.DataAnnotations.Schema;
using HellsingLogistics.Domain.Common;

namespace HellsingLogistics.Domain.BluePrints;

public class BlueprintSubCategory : BaseEntity
{
    public string Name { get; set; }
    public BlueprintCategory ParentCategory {get; set;}

}

