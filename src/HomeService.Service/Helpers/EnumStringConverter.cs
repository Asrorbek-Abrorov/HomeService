using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace HomeService.Service.Helpers;

public class EnumStringConverter : StringEnumConverter
{
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        writer.WriteValue(value.ToString());
    }
}