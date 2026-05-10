using ReadersBookBank.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadersBookBank.DAL.Repository
{
    public class Repository : IRepository
    {
        BookDbContext db = new BookDbContext();

        public bool AddBook(BookDetail book)
        {
            db.BookDetails.Add(book);
            db.SaveChanges();
            return true;
        }

        public BookDetail GetBookById(int bookId)
        {
            return db.BookDetails.Find(bookId);
        }

        public bool RemoveBook(int bookId)
        {
            var book = db.BookDetails.Find(bookId);

            if (book != null)
            {
                db.BookDetails.Remove(book);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateBook(BookDetail book)
        {
            var existingBook = db.BookDetails.Find(book.Id);
            if (existingBook != null)
            {
                existingBook.BookName = book.BookName;
                existingBook.Genre = book.Genre;
                existingBook.AvailabilityStatus = book.AvailabilityStatus;

                db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<BookDetail> ViewAllBooks()
        {
            return db.BookDetails.ToList();
        }
    }
}
