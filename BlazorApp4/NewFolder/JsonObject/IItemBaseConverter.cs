using BlazorApp4.NewFolder.Constants;
using BlazorApp4.NewFolder.Implementation;
using BlazorApp4.NewFolder.Interfaces;
using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;

namespace BlazorApp4.NewFolder.JsonObject
{
    public class IItemBaseConverter : JsonTypeConverter<IItemBase>
    {
        public override IItemBase Create(Type ObjectType, JObject JObject)
        {
            var items = JObject.Value<string>("items");
            switch (items)
            {
                case ConstantsObject.ITEMTITLE:
                    return new ItemTitle();
                case ConstantsObject.ITEMURL:
                    return new ItemUrl();
                case ConstantsObject.ITEMDESCRIPTION: 
                    return new ItemDescription();
                case ConstantsObject.ITEMMENULIST: 
                    return new ItemMenuList();
                default:
                    return new ItemTitle();
            }
        }
    }
}
