
using BlazorApp4.NewFolder.Interfaces;
using BlazorApp4.NewFolder.JsonObject;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp4.NewFolder.Implementation
{
    [Serializable]
    [JsonConverter(typeof(IItemBaseConverter))]
    public class ItemUrl: IItemBase
    {
        public string Url { get; set; }
        public string Title { get; set; }
        public string? ImageSource { get; set; }
        public string ItemBaseType { get; set; }
    }
}
