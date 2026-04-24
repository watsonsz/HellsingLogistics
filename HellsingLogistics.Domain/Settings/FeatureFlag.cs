namespace HellsingLogistics.Domain.Settings;

public class FeatureFlag
{
    public int Id { get; set; }
    public string Key { get; set; } = string.Empty;
    public bool IsEnabled { get; set; }
    public string? Description { get; set; }
}
