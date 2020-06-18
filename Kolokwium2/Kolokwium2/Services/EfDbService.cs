using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Services
{
    public class EfDbService : IFootballDbService
    {
        private readonly s18589Context _context;

        public EfDbService(s18589Context context)
        {
            _context = context;
        }

        public ICollection<Team> GetTeamsList(int championshipId)
        {
            List<Team> response = new List<Team>();

            return response;
        }
    }
}
