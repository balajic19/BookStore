using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Dynamic;
namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration configuration;
        public HomeController(IConfiguration _configuration)
        {
            configuration = _configuration;
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
