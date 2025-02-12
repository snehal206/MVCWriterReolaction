using Microsoft.AspNetCore.Mvc;

namespace MVCWriterReolaction.Controllers
{
    public class PostController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
