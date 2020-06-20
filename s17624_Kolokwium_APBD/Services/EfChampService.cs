using Microsoft.EntityFrameworkCore;
using s17624_Kolokwium_APBD.DTO;
using s17624_Kolokwium_APBD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s17624_Kolokwium_APBD.Services
{
    public class EfChampService : IChampService
    {
        private readonly ChampDBContext _db;

        public EfChampService(ChampDBContext db)
        {
            _db = db;
        }

        public DTOTeams getTeamsInfo(int id)
        {
            /*
            var teams = _db.Team.Include(t => t.Championship_team).
            ThenInclude(ct => ct.Champtionship).
            Where(t => t.IdChampionship == id).SingleOrDefault().


            return new DTOTeams();
        }

        public DTOPlayer assignPlayer()
        {
            return new DTOPlayer();
        }

    }
}
