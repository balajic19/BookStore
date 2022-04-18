using BookStore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Dynamic;
namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly IUserService _userService;
        private readonly IEmailService _emailService;
        public HomeController(IConfiguration _configuration, IUserService userService,
            IEmailService emailService)
        {
            configuration = _configuration;
            _userService = userService;
            _emailService = emailService;
        }
        public ViewResult Index()
        {

            return View();
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
