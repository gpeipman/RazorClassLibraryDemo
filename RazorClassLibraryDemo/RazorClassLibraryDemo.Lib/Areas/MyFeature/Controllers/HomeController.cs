using Microsoft.AspNetCore.Mvc;

namespace RazorClassLibraryDemo.Lib.Areas.MyFeature.Controllers
{
    [Area("MyFeature")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OverrideExample()
        {
            return View();
        }
    }
}
