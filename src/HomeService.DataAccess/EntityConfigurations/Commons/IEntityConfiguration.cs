using Microsoft.EntityFrameworkCore;

namespace HomeService.DataAccess.EntityConfigurations.Commons;

public interface IEntityConfiguration
{
    void Configure(ModelBuilder modelBuilder);
    void SeedData(ModelBuilder modelBuilder);
}
