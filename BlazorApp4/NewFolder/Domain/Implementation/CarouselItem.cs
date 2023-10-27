using BasicBlazorApp1.Core.Domain.Aplication.Interfaces;
using BlazorPracticeBasic.Core.Domain.Aplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPracticeBasic.Infraestructure.Implementation
{
    public class CarouselItem : IBaseCarousel
    {
        public string ImageSource { get ; set ; }
        public IBaseItem? BaseItem { get ; set ; }
    }
}
