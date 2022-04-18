using BookStore.Models;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public interface IEmailService
    {
        Task SendEmailForEmailConfirmation(UserEmailOptions userEmailOptions);
        Task SendEmailForForgotPassword(UserEmailOptions userEmailOptions);
    }
}