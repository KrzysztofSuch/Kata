using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MoqTests.TestoweKlasy
{
    public interface IFetch
    {
        //add members as necessary
        IDataReader ExecuteDataReader(string connectionString,
        string storedProcedureName, SqlParameter[] parameters);
    }

    public class Fetch : IFetch
    {

        public IDataReader ExecuteDataReader(string connectionString,
        string storedProcedureName, SqlParameter[] parameters)
        {
            return SqlHelper.ExecuteReader(connectionString,
            CommandType.StoredProcedure, storedProcedureName,
            parameters);
        }

    }
}