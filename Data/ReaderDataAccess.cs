using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Data
{
    public class ReaderDataAccess : DbDataAccess<Reader>
    {

        public override void Select()
        {
            var selectSqlScript = "select * from Reader where IsDebitor = 1;";
            var command = new SqlCommand(selectSqlScript, connection);
            var dataReader = command.ExecuteReader();
            var readers = new List<Reader>();

            while (dataReader.Read())
            {
                readers.Add(new Reader
                {
                    Id = int.Parse(dataReader["Id"].ToString()),
                    FullName = dataReader["FullName"].ToString(),
                    Address = dataReader["Address"].ToString(),
                    Phone = dataReader["Phone"].ToString(),
                    IsDebitor = bool.Parse(dataReader["IsDebitor"].ToString())
                }); 
            }
            foreach (var item in readers)
            {
                Console.WriteLine($"Id: {item.Id}\nФИО: {item.FullName}\nАдрес: {item.Address}\nТелефон: {item.Phone}\nДолжник: {item.IsDebitor}");
            }
            dataReader.Close();
            command.Dispose();
           
        }
        public void ResetToZero()
        {
            var selectSqlScript = "update Reader set IsDebitor = 0 where IsDebitor = 1;";
            var command = new SqlCommand(selectSqlScript, connection);
            var dataReader = command.ExecuteReader();
            var readers = new List<Reader>();

            while (dataReader.Read())
            {
                readers.Add(new Reader
                {
                    Id = int.Parse(dataReader["Id"].ToString()),
                    FullName = dataReader["FullName"].ToString(),
                    Address = dataReader["Address"].ToString(),
                    Phone = dataReader["Phone"].ToString(),
                    IsDebitor = bool.Parse(dataReader["IsDebitor"].ToString())
                });
            }
            
            dataReader.Close();
            command.Dispose();
            
        }

    }
}
