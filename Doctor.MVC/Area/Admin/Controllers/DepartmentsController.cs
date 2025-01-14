using Doctor.BL.ViewModel.Departments;
using Microsoft.AspNetCore.Mvc;

namespace Doctor.MVC.Area.Admin.Controllers
{
    public class DepartmentsController : Controller
    {
       public async Task<IActionResult> Create (CreateDepartmentVM vm)
        {
            return View();
        }
    }
}
