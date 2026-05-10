using Microsoft.AspNetCore.Mvc;
using ReadersBookBank.DAL.Models;
using ReadersBookBankMVC.Models;
using ReadersBookBank.DAL.Repository;

namespace ReadersBookBankMVC.Controllers
{
    public class BookController : Controller
    {
        ReadersBookBank.DAL.Repository.Repository repository =
            new ReadersBookBank.DAL.Repository.Repository();

        // VIEW ALL BOOKS

        public IActionResult ViewAllBooks()
        {
            var books = repository.ViewAllBooks();

            return View(books);
        }

        // ADD BOOK GET

        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }

        // ADD BOOK POST

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            if (ModelState.IsValid)
            {
                BookDetail bookDetail = new BookDetail()
                {
                    BookName = book.BookName,
                    Genre = book.Genre,
                    AvailabilityStatus = book.AvailabilityStatus
                };

                repository.AddBook(bookDetail);

                return RedirectToAction("ViewAllBooks");
            }

            return View();
        }

        // EDIT BOOK GET

        [HttpGet]
        public IActionResult EditBook(int bookId)
        {
            var book = repository.GetBookById(bookId);

            return View(book);
        }

        // EDIT BOOK POST

        [HttpPost]
        public IActionResult EditBook(BookDetail book)
        {
            repository.UpdateBook(book);

            return RedirectToAction("ViewAllBooks");
        }

        // DELETE BOOK GET

        [HttpGet]
        public IActionResult RemoveBook(int bookId)
        {
            var book = repository.GetBookById(bookId);

            return View(book);
        }

        // DELETE BOOK POST

        [HttpPost]
        public IActionResult RemoveBook(BookDetail book)
        {
            repository.RemoveBook(book.Id);

            return RedirectToAction("ViewAllBooks");
        }
    }
}