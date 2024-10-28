using HomeService.Service.Configurations;

namespace HomeService.WebApi.Models.Assets;

public class AssetCreateModel
{
    public IFormFile File { get; set; }
    public FileType FileType { get; set; }
}