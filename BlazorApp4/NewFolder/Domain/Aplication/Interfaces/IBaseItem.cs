using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBlazorApp1.Core.Domain.Aplication.Interfaces
{
    public interface IBaseItem
    {
        public string Title { get; set; }
        public string? ImageSource { get; set; }
    }
}
