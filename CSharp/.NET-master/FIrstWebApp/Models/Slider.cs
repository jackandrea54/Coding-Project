using System;
using System.Collections.Generic;

#nullable disable

namespace FIrstWebApp.Models
{
    public partial class Slider
    {
        public int SliderId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int ProductId { get; set; }
        public int SliderColectionId { get; set; }

        public virtual Product Product { get; set; }
        public virtual SliderColection SliderColection { get; set; }
    }
}
