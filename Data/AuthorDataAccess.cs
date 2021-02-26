using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Data
{
    public class AuthorDataAccess : DbDataAccess<Author>
    {
        public override void Select()
        {
            var selectSqlScript = "select FullName from Authors join AuthorsAndBooks on Authors.Id = AuthorsAndBooks.AuthorId join Books on AuthorsAndBooks.Id = Books.Id Where Books.Id = 3; ";
            var command = new SqlCommand(selectSqlScript, connection);
            var dataReader = command.ExecuteReader();
            var authors = new List<Author>();

            while (dataReader.Read())
            {
                authors.Add(new Author
                {                    
                    FullName = dataReader["FullName"].ToString()                    
                });
            }
            foreach (var item in authors)
            {
                Console.WriteLine($"ФИО: {item.FullName}");
            }
            dataReader.Close();
            command.Dispose();
            
        }
    }
}
