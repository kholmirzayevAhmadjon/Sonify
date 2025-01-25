using Sonify.Domain.Commons;

namespace Sonify.Domain.Entities.Users;

public class RolePermission : Auditable
{
    public long RoleId { get; set; }
    public UserRole Role { get; set; }
    public long PermissionID { get; set; }
    public Permission Permission { get; set; }
}
