using BookStore.Repo;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BookStore.Components
{
    public class TopBooksViewComponent : ViewComponent
    {
        private readonly BookRepo _bookRepository;

        public TopBooksViewComponent(BookRepo bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            var books = await _bookRepository.GetTopBooksAsync(count);
            return View(books);
        }
    }
}
