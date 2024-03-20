using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Edit
        public IActionResult Edit(int? id)
        {
            if (id.HasValue)
                //return View()
                return new ContentResult { Content = id.ToString() };
            else
                return new ContentResult { Content = "Not Found Content" };
        }
    }
}
