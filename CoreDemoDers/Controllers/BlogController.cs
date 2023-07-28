using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemoDers.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EBlogRepository());


        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
    }
}
