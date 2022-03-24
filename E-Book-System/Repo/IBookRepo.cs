using E_Book_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Book_System.Repo
{
   public interface IBookRepo
    {

        Book AddBook(Book book);

        IEnumerable<Book> GetAllBooks();

        Book GetBook(string BookID);

        Book BookUpdate(Book bookTobeSave);

        IEnumerable<Book> GetHomePageBooks();
    }
}
