using Sonify.Domain.Commons;
using Sonify.Domain.Entities.Books;
using Sonify.Domain.Enums;

namespace Sonify.Domain.Entities.Users;

public class CustomAudioRequests: Auditable
{
    public long UserId { get; set; } 
    public User User { get; set; } 
    public long BookId { get; set; } 
    public Book Book { get; set; } 
    public string RequestDetails { get; set; } 
    public RequestStatus Status { get; set; }
}
