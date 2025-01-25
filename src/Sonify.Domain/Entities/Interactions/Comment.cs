using Sonify.Domain.Commons;
using Sonify.Domain.Entities.Books;
using Sonify.Domain.Entities.Users;

namespace Sonify.Domain.Entities.Interactions
{
    public class Comment : Auditable
    {
        public long AudioId { get; set; }
        public AudioBook Audio {  get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        public long? ParentCommentId { get; set; }
        public string CommentText { get; set; }
    }
}
