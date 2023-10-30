using BlazorApp4.NewFolder.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp4.NewFolder.Implementation
{
    public class Article : ItemBase
    {
        public string Quote { get; set; }
        public string Description { get; set; }
    }


}
