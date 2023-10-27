using BasicBlazorApp1.Core.Domain.Aplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBlazorApp1.Infraestructure.Implementation
{
    public class ItemUrl : IBaseItem
    {
        public string Title { get; set ; }
        public string Url { get; set; }
        public string? ImageSource { get; set; }
    }
}
