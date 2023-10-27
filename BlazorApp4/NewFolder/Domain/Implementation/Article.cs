using BasicBlazorApp1.Core.Domain.Aplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPracticeBasic.Infraestructure.Implementation
{
    public class Article : IBaseItem
    {
        public string Title { get; set; }
        public string Quote { get; set; }
        public string Description { get; set; }
        public string? ImageSource { get; set; }
    }


}
