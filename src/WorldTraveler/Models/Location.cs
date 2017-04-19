using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace World_Traveler.Models
{
    [Table("Location")]
    public class Location
    {
        public Location()
        {
            this.Experiences = new HashSet<Experience>();
        }

        [Key]
        public int LocationId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public virtual ICollection<Experience> Experiences { get; set; }
    }
}
