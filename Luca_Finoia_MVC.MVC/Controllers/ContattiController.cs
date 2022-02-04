using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Luca_Finoia_MVC.MVC.Controllers
{
    [Authorize]
    public class ContattiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
