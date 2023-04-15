using Microsoft.AspNetCore.Mvc;
using MVCPractica01.Models;
using WebMVCPractica2.Models;

namespace WebMVCPractica2.Controllers
{
    public class EquiposController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create([Bind()] equipos Dequipos)
        {
            return View("Index");
        }
    }
}
