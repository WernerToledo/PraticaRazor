using Microsoft.AspNetCore.Mvc;

namespace WebMVCPractica2.Controllers
{
    public class frmController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
