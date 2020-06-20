using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace s17624_Kolokwium_APBD.Models
{
    public class Team
    {
        [Key]
        public int IdTeam { get; set; }
        [MaxLength(30)]
        public string TeamName { get; set; }
        public int MaxAge { get; set; }

        public virtual ICollection<Championship_Team> Championship_Teams { get; set; }
    }
}
