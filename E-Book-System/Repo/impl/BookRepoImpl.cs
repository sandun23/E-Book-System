using E_Book_System.Data;
using E_Book_System.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace E_Book_System.Repo.impl
{
    public class BookRepoImpl : IBookRepo
    {
        private readonly ApplicationDbContext _context;

        public BookRepoImpl(ApplicationDbContext context)
        {
            _context = context;
        }

        public Book AddBook(Book book)
        {

            _context.Books.Add(book);
        _context.SaveChanges();
            return book;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            var books = _context.Books.ToList();
            return books;
        }
        
        public IEnumerable<Book> GetHomePageBooks()
        {
            var books = _context.Books.ToList().Take(4);
            return books;
        }

        public Book GetBook(string BookID)
        {
            var book = _context.Books.Find(BookID);


            if(book != null)
            {
                return book;
            }
            else
            {
                return null;
            }
        }

        public Book BookUpdate(Book bookTobeSave)
        {

            var bookAlreadyDetails = _context.Books.Find(bookTobeSave.BookID);

            bookAlreadyDetails.BookName = bookTobeSave.BookName;
            bookAlreadyDetails.BookQty = bookTobeSave.BookQty;
            bookAlreadyDetails.BookDesc = bookTobeSave.BookDesc ;
            bookAlreadyDetails.BookPrice = bookTobeSave.BookPrice;
            bookAlreadyDetails.BookCategory = bookTobeSave.BookCategory;
            bookAlreadyDetails.BookAuthorName = bookTobeSave.BookAuthorName;
            bookAlreadyDetails.BookType = bookTobeSave.BookType;
            bookAlreadyDetails.BookID = bookTobeSave.BookID;
            bookAlreadyDetails.BookImageFileName = bookTobeSave.BookImageFileName;

            _context.SaveChanges();
            return bookAlreadyDetails;


        }

    }
}
