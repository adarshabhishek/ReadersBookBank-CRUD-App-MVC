using Azure;
using ReadersBookBank.DAL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace ReadersBookBank.DAL.Repository
{
    public interface IRepository
    {
        public bool AddBook(BookDetail book);
        public List<BookDetail> ViewAllBooks();
        public bool RemoveBook(int bookId);
        public bool UpdateBook(BookDetail book);
        public BookDetail GetBookById(int bookId);
    }
}
