using Microsoft.AspNetCore.Mvc;

namespace examAzure.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
