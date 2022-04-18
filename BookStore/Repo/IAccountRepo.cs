using BookStore.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace BookStore.Repo
{
    public interface IAccountRepo
    {
        Task<IdentityResult> CreateUserAsync(SignUpUserModel userModel);

        Task<IdentityResult> ConfirmEmailAsync(string uid, string token);
    }
}