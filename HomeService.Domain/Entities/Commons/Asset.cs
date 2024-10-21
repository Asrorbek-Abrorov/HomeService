using HomeService.Domain.Commons;
using HomeService.Domain.Entities.Posts;

namespace HomeService.Domain.Entities.Commons;

public class Asset : Auditable
{
    public string Name { get; set; }
    public string Path { get; set; }
    public long PostId { get; set; }
    public Post Post { get; set; }
}
