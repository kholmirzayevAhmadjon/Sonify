using Microsoft.EntityFrameworkCore;
using Sonify.Domain.Commons;
using Sonify.Domain.Entities.Books;
using Sonify.Domain.Entities.Commons;
using Sonify.Domain.Entities.Interactions;
using Sonify.Domain.Entities.Playliists;
using Sonify.Domain.Entities.Users;

namespace Sonify.DataAccess.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options) { }

    DbSet<User> Users { get; set; }
    DbSet<UserRole> UserRoles { get; set; }
    DbSet<Permission> Permissions { get; set; }
    DbSet<RolePermission> RolePermissions { get; set; }
    DbSet<CustomAudioRequests> CustomAudioRequests { get; set; }
    DbSet<Asset> Asset { get; set; }
    DbSet<Playlist> Playlists { get; set; }
    DbSet<PlaylistItem> PlaylistItems { get; set; }
    DbSet<Comment> Comments { get; set; }    
    DbSet<Like> Likes { get; set; }
    DbSet<Book> Books { get; set; }
    DbSet<AudioBook> AudioBooks { get; set; }
}
