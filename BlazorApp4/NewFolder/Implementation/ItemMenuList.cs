
using BlazorApp4.NewFolder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp4.NewFolder.Implementation
{
    [Serializable]
    public class ItemMenuList : IItemBase
    {
        public List<IItemBase> Items { get; set; }
        public string Title { get; set; }
        public string? ImageSource { get; set; }
    }
}