using Sonify.DataAccess.Contexts;
using Sonify.DataAccess.Repositories;
using Sonify.Domain.Entities.Books;
using Sonify.Domain.Entities.Commons;
using Sonify.Domain.Entities.Interactions;
using Sonify.Domain.Entities.Playliists;
using Sonify.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore.Storage;


namespace Sonify.DataAccess.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext context;
    public IRepository<User> Users { get; }
    public IRepository<Like> Likes { get; }
    public IRepository<Book> Books { get; }
    public IRepository<Asset> Assets { get; }
    public IRepository<Comment> Comments { get; }
    public IRepository<UserRole> UserRoles { get; }
    public IRepository<Playlist> Playlists { get; }
    public IRepository<AudioBook> AudioBooks { get; }                      
    public IRepository<Permission> Permissions { get; }
    public IRepository<PlaylistItem> PlaylistItems { get; }
    public IRepository<RolePermission> RolePermissions { get; }
    public  IRepository<CustomAudioRequests> CustomAudioRequests { get; }
    private IDbContextTransaction transaction;

    public UnitOfWork(AppDbContext context)
    {
        this.context = context;
        Likes = new Repository<Like>(this.context);
        Books = new Repository<Book>(this.context);
        Users = new Repository<User>(this.context);
        Assets = new Repository<Asset>(this.context);
        Comments = new Repository<Comment>(this.context);
        UserRoles = new Repository<UserRole>(this.context);
        Playlists = new Repository<Playlist>(this.context);
        AudioBooks = new Repository<AudioBook>(this.context);
        Permissions = new Repository<Permission>(this.context);
        PlaylistItems = new Repository<PlaylistItem>(this.context);
        RolePermissions = new Repository<RolePermission>(this.context); 
        CustomAudioRequests = new Repository<CustomAudioRequests>(this.context);
    }
    public async ValueTask BeginTransactionAsync()
    {
        transaction = await this.context.Database.BeginTransactionAsync();
    }

    public async ValueTask CommitTransactionAsync()
    {
        await transaction.CommitAsync();
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }

    public async ValueTask<bool> SaveAsync()
    {
        return await context.SaveChangesAsync() > 0;
    }
}
