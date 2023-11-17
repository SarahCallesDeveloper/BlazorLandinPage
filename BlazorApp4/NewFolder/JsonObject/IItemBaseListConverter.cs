using BlazorApp4.NewFolder.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BlazorApp4.NewFolder.JsonObject
{
    public class IItemBaseListConverter : JsonConverter<List<IItemBase>>
    {
        public override List<IItemBase>? ReadJson(JsonReader reader, Type objectType, List<IItemBase>? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            // Implement the logic for deserialization here
            JArray array = JArray.Load(reader);
            List<IItemBase> items = new List<IItemBase>();
            IItemBaseConverter itemBaseConverter = new IItemBaseConverter();

            foreach (JToken itemToken in array)
            {
                // Use your existing IItemBaseConverter logic for creating items
                IItemBase item = (IItemBase)itemBaseConverter.ReadJson(itemToken.CreateReader(), typeof(IItemBase), null, serializer);
                items.Add(item);
            }

            return items;
        }

        public override void WriteJson(JsonWriter writer, List<IItemBase>? value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
