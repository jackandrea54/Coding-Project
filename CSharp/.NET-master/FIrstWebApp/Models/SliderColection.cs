using System;
using System.Collections.Generic;

#nullable disable

namespace FIrstWebApp.Models
{
    public partial class SliderColection
    {
        public SliderColection()
        {
            Sliders = new HashSet<Slider>();
        }

        public int SliderColectionId { get; set; }
        public string SliderColectionName { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public int AdminId { get; set; }
        public bool? Status { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual ICollection<Slider> Sliders { get; set; }
    }
}
