namespace HellsingLogistics.Domain.Identity;

public class AppRole
{
    public int Id { get; set; }
    public UserRoleType RoleType { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }

    public ICollection<AppUserRole> UserRoles { get; set; } = new List<AppUserRole>();
}
