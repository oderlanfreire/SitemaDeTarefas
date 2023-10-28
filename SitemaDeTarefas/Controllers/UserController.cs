using Microsoft.AspNetCore.Mvc;

namespace SitemaDeTarefas.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
