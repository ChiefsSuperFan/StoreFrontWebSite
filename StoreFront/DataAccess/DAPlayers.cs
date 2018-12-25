using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using StoreFront.Models;
//using System.Data;
//using System.Data.SqlClient;
using System.Threading.Tasks;



namespace StoreFront.DataAccess
{
    public class DAPlayers:DABaseClass
    {
        

        public DAPlayers()
        {
           

        }

        public async Task<IEnumerable<Player>> GetPlayers()
        {
            string storedProc = "uspGetPlayers";

            IEnumerable<Player> players = await GetRows<Player>(storedProc);
            return players;
        }

       
      
    }
}