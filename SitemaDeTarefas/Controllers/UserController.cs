using Microsoft.AspNetCore.Mvc;
using SitemaDeTarefas.Models;

namespace SitemaDeTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult <List<UserModel>> GetAllUsers()
        {
            return Ok();
        }
    }
}
