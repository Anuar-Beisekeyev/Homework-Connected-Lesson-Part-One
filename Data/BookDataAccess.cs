using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace Data
{
    public class BookDataAccess : DbDataAccess<Book>
    {
        public override void Select()
        {
            var selectSqlScript = "select * from Books; ";
            var command = new SqlCommand(selectSqlScript, connection);
            var dataReader = command.ExecuteReader();
            var books = new List<Book>();

            while (dataReader.Read())
            {
                books.Add(new Book
                {
                    Id = int.Parse(dataReader["Id"].ToString()),
                    Title = dataReader["Title"].ToString(),
                    PublishingHouse = dataReader["PublishingHouse"].ToString(),
                    YearPublication = int.Parse(dataReader["YearPublication"].ToString())
                    
                });
            }
            foreach (var item in books)
            {
                Console.WriteLine($"Id: {item.Id}\nНазвание: {item.Title}\nИздательство: {item.PublishingHouse}\nГод издания: {item.YearPublication}");
            }
            dataReader.Close();
            command.Dispose();
           
        }
        public void BookSelect() 
        {

            var selectSqlScript = "select * from Books join Extradition on Extradition.Id = Books.Id join Reader on Reader.Id = Extradition.Id where Reader.Id = 2;";
            var command = new SqlCommand(selectSqlScript, connection);
            var dataReader = command.ExecuteReader();
            var books = new List<Book>();

            while (dataReader.Read())
            {
                books.Add(new Book
                {
                    Id = int.Parse(dataReader["Id"].ToString()),
                    Title = dataReader["Title"].ToString(),
                    PublishingHouse = dataReader["PublishingHouse"].ToString(),
                    YearPublication = int.Parse(dataReader["YearPublication"].ToString())

                });
            }
            foreach (var item in books)
            {
                Console.WriteLine($"Id: {item.Id}\nНазвание: {item.Title}\nИздательство: {item.PublishingHouse}\nГод издания: {item.YearPublication}");
            }
            dataReader.Close();
            command.Dispose();
           
        }
    }
}
