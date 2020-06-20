using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace s17624_Kolokwium_APBD.Models
{
    public class Championship
    {
        [Key]
        public int IdChampionship { get; set; }
        [MaxLength(100)]
        public string OfficialName { get; set; }
        public int Year { get; set; }

        public virtual ICollection<Championship_Team> Championship_Teams { get; set; }

    }
}
