using HomeService.Domain.Commons;
using HomeService.Domain.Entities.Users;

namespace HomeService.Domain.Entities.Posts;

public class Post : Auditable
{
    public string Title { get; set; }
    public string Description { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }
}
