using Microsoft.AspNetCore.Mvc;

namespace Mobile_Application_Sales_Site.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
