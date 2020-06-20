using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s17624_Kolokwium_APBD.Models
{
    public class ChampDBContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Championship> Championships { get; set; }
        public DbSet<Championship_Team> Championship_Teams {get; set;}

        public DbSet<Player_Team> Player_Teams { get; set; }

        public ChampDBContext()
        {

        }

        public ChampDBContext(DbContextOptions options) : base(options)
        {

        }
    
       
    }
}
