using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
