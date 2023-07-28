using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemoDers.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new ECategoryRepository());


        public IActionResult Index()
        {
            var values = cm.GetList();
            
            return View(values);
        }
    }
}
