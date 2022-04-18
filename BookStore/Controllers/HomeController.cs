using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
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
