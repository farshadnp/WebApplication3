using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class Person : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
