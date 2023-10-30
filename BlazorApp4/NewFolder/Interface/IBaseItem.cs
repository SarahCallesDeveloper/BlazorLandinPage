using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp4.NewFolder.Interface
{
    public interface IBaseItem
    {
        public string Title { get; set; }
        public string? ImageSource { get; set; }
    }
}
