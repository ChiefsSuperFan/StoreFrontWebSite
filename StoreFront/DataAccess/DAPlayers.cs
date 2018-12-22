using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using StoreFront.Models;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;



namespace StoreFront.DataAccess
{
    public class DAPlayers
    {
        readonly private string _dbConnect = "";

        public DAPlayers()
        {
            _dbConnect = StoreFront.Properties.Settings.Default.dbconnect;

        }

        public async Task<IEnumerable<Player>> GetPlayers()
        {
            //IEnumerable<Player> players; 
            IEnumerable<Player> players = new List<Player>();
            try
            {
                using (var connection = new SqlConnection(_dbConnect))
                {
                     players = await connection.QueryAsync<Player>("uspGetPlayers", CommandType.StoredProcedure);
                }

                return players;
            }
            catch
            {

                return players;
            }
        }
      
    }
}