using HomeService.DataAccess.Contexts;
using HomeService.DataAccess.Repositories;
using HomeService.Domain.Entities.Commons;
using HomeService.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore.Storage;

namespace HomeService.DataAccess.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext context;
    public IRepository<User> Users { get; }
    public IRepository<Asset> Assets { get; }
    public IRepository<UserRole> UserRoles { get; }
    public IRepository<Permission> Permissions { get; }
    public IRepository<RolePermission> RolePermissions { get; }
    private IDbContextTransaction transaction;

    public UnitOfWork(AppDbContext context)
    {
        this.context = context;
        Users = new Repository<User>(this.context);
        Assets = new Repository<Asset>(this.context);
        UserRoles = new Repository<UserRole>(this.context);
        Permissions = new Repository<Permission>(this.context);
        RolePermissions = new Repository<RolePermission>(this.context);
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }

    public async ValueTask<bool> SaveAsync()
    {
        return await context.SaveChangesAsync() > 0;
    }

    public async ValueTask BeginTransactionAsync()
    {
        transaction = await this.context.Database.BeginTransactionAsync();
    }

    public async ValueTask CommitTransactionAsync()
    {
        await transaction.CommitAsync();
    }
}