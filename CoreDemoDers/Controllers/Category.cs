using Microsoft.AspNetCore.Mvc;

namespace CoreDemoDers.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
