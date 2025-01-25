using Sonify.Domain.Commons;
using Sonify.Domain.Entities.Books;

namespace Sonify.Domain.Entities.Playliists;

public class PlaylistItem : Auditable
{
    public long AudioId { get; set; }
    public AudioBook Audio {  get; set; }
    public long PlaylistId { get; set; }
    public Playlist Playlist { get; set; }
}
