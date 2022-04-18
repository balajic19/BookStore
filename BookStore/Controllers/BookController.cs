using BookStore.Models;
using BookStore.Repo;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepo _bookRepo = null;
        public BookController()
        {
            _bookRepo = new BookRepo();
        }
        public ViewResult GetAllBooks()
        {
            var result = _bookRepo.GetAllBooks();
            return View(result);
        }

        public ViewResult GetBook(int id)
        {
            var result =  _bookRepo.GetBookById(id);
            return View(result);
        }

        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepo.SearchBook(bookName, authorName);
        }

        public ViewResult AddNewBook()
        {
            return View();
        }
    }
}
