using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StoreFront.Models;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;

namespace StoreFront.DataAccess
{
    public class DABaseClass
    {
        readonly private string _dbConnect = "";

        public DABaseClass()
        {
            _dbConnect = StoreFront.Properties.Settings.Default.dbconnect;
        }

        public async Task<IEnumerable<T>> GetRows<T> (string storedProc)
        {

            IEnumerable<T> rows = new List<T>();
            try
            {
                using (var connection = new SqlConnection(_dbConnect))
                {
                    rows = await connection.QueryAsync<T>(storedProc, CommandType.StoredProcedure);
                }

                return rows;
            }
            catch
            {

                return rows;
            }
        }

    }
}