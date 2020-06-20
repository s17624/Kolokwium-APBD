using s17624_Kolokwium_APBD.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s17624_Kolokwium_APBD.Services
{
    public interface IChampService
    {
        public DTOTeams getTeamsInfo(int id);

        public DTOPlayer assignPlayer();
    }
}
