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
        private readonly LanguageRepo _languageRepo = null;
        public BookController(BookRepo bookRepo, LanguageRepo languageRepo)
        {
            _bookRepo = bookRepo;
            _languageRepo = languageRepo;        }
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

        public async Task<ViewResult> AddNewBook(bool isSuccess = false, int bookId = 0)
        {
            
            ViewBag.Language = await _languageRepo.GetLanguages();
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
            ViewBag.Language = await _languageRepo.GetLanguages();
            return View();
        }


    }
}
