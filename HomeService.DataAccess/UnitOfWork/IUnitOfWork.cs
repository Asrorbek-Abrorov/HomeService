using HomeService.DataAccess.Repositories;
using HomeService.Domain.Entities.Commons;
using HomeService.Domain.Entities.Users;

namespace HomeService.DataAccess.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    IRepository<User> Users { get; }
    IRepository<Asset> Assets { get; }
    IRepository<UserRole> UserRoles { get; }
    IRepository<Permission> Permissions { get; }
    IRepository<RolePermission> RolePermissions { get; }
    ValueTask<bool> SaveAsync();
    ValueTask BeginTransactionAsync();
    ValueTask CommitTransactionAsync();
}
