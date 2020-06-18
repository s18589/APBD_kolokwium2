using Kolokwium2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Services
{
    public interface IFootballDbService
    {
        public ICollection<Team> GetTeamsList(int championshipId);

    }
}
