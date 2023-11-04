
using BlazorApp4.NewFolder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorApp4.NewFolder.Implementation
{
    [Serializable]
    public class ItemDescription: IItemBase
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public string? ImageSource { get; set; }
    }
}
