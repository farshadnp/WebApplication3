using Microsoft.AspNetCore.Mvc;
using SadrTools.Utility;
using SampleData;
namespace WebApplication3.Controllers
{
    public class Person : Controller
    {
        public IActionResult Index()
        {

            var personelList = Personel.GetPeople();

            ViewData[StaticValues.ViewData.Title] = "My title is here";

            return View(personelList);
        }
    }
}
