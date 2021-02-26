using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Data
{
    public abstract class DbDataAccess<T> : IDisposable
    {
        protected readonly SqlConnection connection;
        public DbDataAccess()
        {
            connection = new SqlConnection();
            connection.ConnectionString = "Server=DESKTOP-3S2N5VP; Database=CentralLibrary; Trusted_Connection=true;";
            connection.Open();
        }
        public void Dispose()
        {
            connection.Close();
        }
        public abstract void Select();


    }
}
