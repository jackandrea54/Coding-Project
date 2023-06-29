using System;
using System.Collections.Generic;

#nullable disable

namespace FIrstWebApp.Models
{
    public partial class Admin
    {
        public Admin()
        {
            SliderColections = new HashSet<SliderColection>();
        }

        public int AdminId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Image { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmailContact { get; set; }

        public virtual Account AdminNavigation { get; set; }
        public virtual ICollection<SliderColection> SliderColections { get; set; }
    }
}
