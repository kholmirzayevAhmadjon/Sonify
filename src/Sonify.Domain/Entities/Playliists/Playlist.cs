using Sonify.Domain.Commons;
using Sonify.Domain.Entities.Users;

namespace Sonify.Domain.Entities.Playliists;

public class Playlist : Auditable
{
    public string PlaylistName { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }
}
