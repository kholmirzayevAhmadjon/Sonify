using Sonify.Domain.Entities.Books;
using Sonify.Domain.Entities.Users;

namespace Sonify.Domain.Commons;

public class Like : Auditable 
{
    public long UserId { get; set; }
    public User User { get; set; }
    public long AudioBookId { get; set; }
    public AudioBook AudioBook { get; set; }
}
