using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace s17624_Kolokwium_APBD.Models
{
    public class Player
    {
        [Key]
        public int IdPlayer { get; set; }
        [MaxLength(30)]
        public string FirstName{ get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<Player_Team> Player_Teams { get; set; }


    }
}
