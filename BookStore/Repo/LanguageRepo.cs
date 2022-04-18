using BookStore.DataBase;

namespace BookStore.Repo
{
    public class LanguageRepo
    {
        private readonly BookStoreContext _context = null;

        public LanguageRepo(BookStoreContext context)
        {
            _context = context;
        }


    }
}
