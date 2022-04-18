using BookStore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Repo
{
    public interface ILanguageRepo
    {
        Task<List<LanguageModel>> GetLanguages();
    }
}
