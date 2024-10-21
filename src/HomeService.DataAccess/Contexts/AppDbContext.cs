using HomeService.DataAccess.EntityConfigurations.Commons;
using HomeService.Domain.Entities.Commons;
using HomeService.Domain.Entities.Posts;
using HomeService.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HomeService.DataAccess.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Asset> Assets { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<RolePermission> RolePermissions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        ApplyConfigurations(modelBuilder);
    }

    private void ApplyConfigurations(ModelBuilder modelBuilder)
    {
        var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
            .Where(type => !string.IsNullOrEmpty(type.Namespace))
            .Where(type => type.GetInterfaces().Any(inter => inter == typeof(IEntityConfiguration)));

        foreach (var type in typesToRegister)
        {
            var configuration = (IEntityConfiguration)Activator.CreateInstance(type);
            configuration.Configure(modelBuilder);
            configuration.SeedData(modelBuilder); // Call the SeedData method
        }
    }
}
