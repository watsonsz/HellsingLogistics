using System.Reflection.Metadata.Ecma335;
using HellsingLogistics.Domain.Common;

namespace HellsingLogistics.Domain.BluePrints;

public class Material : BaseEntity
{
    public MaterialName Name { get; set; }
    public int Quality { get; set; }
    public double Quantity {get; set;}
    public bool IsActive => Quantity > 0.00;
   
}

