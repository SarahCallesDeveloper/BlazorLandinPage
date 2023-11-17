



using BlazorApp4.NewFolder.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json.Serialization;
using JsonConverter = Newtonsoft.Json.JsonConverter;

namespace BlazorApp4.NewFolder.JsonObject
{
    public abstract class JsonTypeConverter<T> : JsonConverter

    {
        public override bool CanConvert(Type ObjectType)
        {
            return typeof(T).IsAssignableFrom(ObjectType);/* typeToConvert == typeof(IItemBase);*/
        }

        public override object ReadJson( JsonReader reader, Type typeToConvert, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType==null) {
                return null;
            };

            JObject JObject = JObject.Load(reader);
            //Target type == child objecto or end object
            T target = Create(typeToConvert, JObject);
            serializer.Populate(JObject.CreateReader(),target);
            return target;

          /* return serializer.Deserialize(reader, typeof(IItemBase));*/
        }
        public override bool CanWrite { get { return false; } }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
          
        }

        public abstract T Create(Type ObjectType, JObject JObject);
    }

  
}
