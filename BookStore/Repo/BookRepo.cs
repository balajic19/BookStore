using BookStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Repo
{
    public class BookRepo
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x=> x.Title.Contains(title) && x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id = 1, Title = "MVC", Author = "Balaji",Description = "Just Testing", Category = "Programming", Language = "English", TotalPages = 100},
                new BookModel(){Id = 2, Title = "CC", Author = "Balaji",Description = "Just Testing", Category = "Programming", Language = "English", TotalPages = 100},
                new BookModel(){Id = 3, Title = "WEG", Author = "Balaji",Description = "Just Testing", Category = "Programming", Language = "English", TotalPages = 100},
                new BookModel(){Id = 4, Title = "FGH", Author = "Balaji",Description = "Just Testing", Category = "Programming", Language = "English", TotalPages = 100},
                new BookModel(){Id = 5, Title = "WER", Author = "Balaji",Description = "Just Testing", Category = "Programming", Language = "English", TotalPages = 100},
                new BookModel(){Id = 6, Title = "JJU", Author = "Balaji",Description = "Just Testing", Category = "Programming", Language = "English", TotalPages = 100},

            };
        }
    }
}
