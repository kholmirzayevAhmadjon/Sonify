using Sonify.Domain.Commons;

namespace Sonify.Domain.Entities.Users;

public class UserRole : Auditable
{
    public string Name { get; set; }
}
