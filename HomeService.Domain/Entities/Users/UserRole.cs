using HomeService.Domain.Commons;

namespace HomeService.Domain.Entities.Users;

public class UserRole : Auditable
{
    public string Name { get; set; }
}