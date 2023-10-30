using BlazorApp4.NewFolder.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp4.NewFolder.Implementation
{
    public class ItemMenuList : ItemBase
    {
        public List<ItemBase> Items { get; set; }
    }
}