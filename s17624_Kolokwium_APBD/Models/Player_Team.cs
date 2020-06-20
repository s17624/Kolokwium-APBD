using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace s17624_Kolokwium_APBD.Models
{
    public class Player_Team
    {

        public int NumOnShirt { get; set; }

        [MaxLength(300)]
        public string? Comment { get; set; }

        
        public int? IdPlayer { get; set; }
        [ForeignKey("Player")]
        public virtual Player Player { get; set; }

        
        public int? IdTeam { get; set; }
        [ForeignKey("Team")]
        public virtual Team Team { get; set; }

    }
}
