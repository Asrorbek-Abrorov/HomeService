using HomeService.Service.Helpers;
using Newtonsoft.Json;

namespace HomeService.Service.Configurations;

[JsonConverter(typeof(EnumStringConverter))]
public enum FileType
{
    Pictures = 1,
    Videos,
    Audios
}