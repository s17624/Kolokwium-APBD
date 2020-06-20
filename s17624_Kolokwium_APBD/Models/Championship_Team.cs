using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace s17624_Kolokwium_APBD.Models
{
    public class Championship_Team
    {
        public float Score { get; set; }
     
        public int? IdTeam { get; set; }
        
        [ForeignKey("Team")]
        public virtual Team Team { get; set; }
        
        public int? IdChampionship { get; set; }

        [ForeignKey("Championship")]
        public virtual Championship Championship { get; set; }
    }
}