using System;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace Infra.Context
{
    public class Context : IDisposable
    {
        public SqlConnection Connection { get; set; }

        public Context(IConfiguration configuration)
        {
            //Connection = new SqlConnection(_configuration["StringConection"]);
            //Connection.Open();
        }
        public void Dispose()
        {
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }

        }
    }
}
