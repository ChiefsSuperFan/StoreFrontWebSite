using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using StoreFront.Models;

namespace StoreFront.DataAccess
{
    public class DATeams:DABaseClass
    {

        public DATeams()
        {

        }

        public async Task<IEnumerable<Team>> GetTeams()
        {
            string storedProc = "uspGetTeams";

            IEnumerable<Team> teams = await GetRows<Team>(storedProc);
            return teams;
        }
    }
}