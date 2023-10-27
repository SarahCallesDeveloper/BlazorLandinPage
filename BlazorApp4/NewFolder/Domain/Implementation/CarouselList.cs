using BasicBlazorApp1.Core.Domain.Aplication.Interfaces;
using BlazorPracticeBasic.Core.Domain.Aplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPracticeBasic.Infraestructure.Implementation
{
    public class CarouselList
    {
        public List<IBaseCarousel> CarouselItems { get; set; }
    }
}
