using Data;
using Models;
using System;

namespace HomeworkConnectedLevelPartOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var readerDataAccess = new ReaderDataAccess();
            var authorDataAccess = new AuthorDataAccess();
            var bookDataAccess = new BookDataAccess();
            Console.WriteLine("Список должников:");
            readerDataAccess.Select();
            Console.WriteLine();
            Console.WriteLine("Список авторов книги №3:");
            authorDataAccess.Select();
            Console.WriteLine();
            Console.WriteLine("Список доступных книг:");
            bookDataAccess.Select();
            Console.WriteLine();
            Console.WriteLine("Список книг на руках читателя №2:");
            bookDataAccess.BookSelect();
            Console.WriteLine();            
            readerDataAccess.ResetToZero();

            bookDataAccess.Dispose();
            authorDataAccess.Dispose();
            readerDataAccess.Dispose();
            Console.ReadLine();
        }
    }
}