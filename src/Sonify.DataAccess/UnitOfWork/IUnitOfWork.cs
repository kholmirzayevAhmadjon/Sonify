using Microsoft.EntityFrameworkCore.Update.Internal;
using Sonify.DataAccess.Repositories;
using Sonify.Domain.Entities.Books;
using Sonify.Domain.Entities.Commons;
using Sonify.Domain.Entities.Interactions;
using Sonify.Domain.Entities.Playliists;
using Sonify.Domain.Entities.Users;

namespace Sonify.DataAccess.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    IRepository<User> Users { get; }
    IRepository<UserRole> UserRoles { get; }
    IRepository<Permission> Permissions { get; }
    IRepository<RolePermission> RolePermissions { get; }
    IRepository<CustomAudioRequests> CustomAudioRequests { get; }
    IRepository<Playlist> Playlists { get; }
    IRepository<PlaylistItem> PlaylistItems { get; }
    IRepository<Comment> Comments { get; }
    IRepository<Like> Likes { get; }
    IRepository<Asset > Assets { get; }
    IRepository<Book> Books { get; }
    IRepository<AudioBook> AudioBooks { get; }
    ValueTask<bool> SaveAsync();
    ValueTask BeginTransactionAsync();
    ValueTask CommitTransactionAsync();
}
