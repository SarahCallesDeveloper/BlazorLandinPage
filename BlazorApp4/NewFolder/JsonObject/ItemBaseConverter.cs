



using BlazorApp4.NewFolder.Interfaces;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using JsonConverter = Newtonsoft.Json.JsonConverter;

namespace BlazorApp4.NewFolder.JsonObject
{
    public class ItemBaseConverter : JsonConverter

    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert == typeof(IItemBase);
        }

        public override object ReadJson(JsonReader reader, Type typeToConvert, object existingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize(reader, typeof(IItemBase));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}
