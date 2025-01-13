using Microsoft.AspNetCore.Mvc;

namespace Doctor.MVC.Area.Admin.Controllers
{
    public class DoctorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
