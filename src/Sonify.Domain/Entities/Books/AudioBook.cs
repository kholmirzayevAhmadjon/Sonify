using Sonify.Domain.Commons;
using Sonify.Domain.Entities.Commons;
using Sonify.Domain.Entities.Users;

namespace Sonify.Domain.Entities.Books;

public class AudioBook : Auditable
{
    public long BookId { get; set; }
    public Book Book { get; set; }
    public TimeSpan Duration { get; set; }
    public long ConvertedById { get; set; }
    public User ConvertedBy { get; set; }
    public long AudioFilePathId { get; set; }
    public Asset AudioFilePath { get; set; }
    public bool Status { get; set; }
}
