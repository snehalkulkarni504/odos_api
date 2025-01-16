using Microsoft.AspNetCore.Mvc;

namespace ODOS.Controllers
{
    public class ODOSController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
