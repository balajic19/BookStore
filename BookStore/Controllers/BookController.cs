using BookStore.Models;
using BookStore.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepo _bookRepo = null;
        public BookController(BookRepo bookRepo)
        {
            _bookRepo = bookRepo;
        }
        public async Task<ViewResult> GetAllBooks()
        {
            var result = await _bookRepo.GetAllBooks();
            return View(result);
        }

        [Route("book-details/{id}", Name = "bookDetailsRoute")]
        public async Task<ViewResult> GetBook(int id)
        {
            var result =  await _bookRepo.GetBookById(id);
            return View(result);
        }

        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepo.SearchBook(bookName, authorName);
        }

        public ViewResult AddNewBook(bool isSuccess = false, int bookId = 0)
        {
            

            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookId = bookId;
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddNewBook(BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
                int id = await _bookRepo.AddNewBook(bookModel);
                if (id > 0)
                {
                    return RedirectToAction(nameof(AddNewBook), new { isSuccess = true, bookId = id });
                }
                //ViewBag.IsSuccess = false;
                //ViewBag.BookId = 0;
            }
            return View();
        }


    }
}
