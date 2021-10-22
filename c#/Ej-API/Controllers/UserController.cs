using Ej_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ej_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public User[] UserList = new[]
        {
            new User("igna", "garcia", 22),
            new User("juanchi", "garcia", 02),
            new User("palo", "garcia", 14),
            new User("cata", "jonas", 23)
        };

        [HttpGet]
         public ActionResult<User[]> GetAll()
        {
            return Ok(UserList);
         }

        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            return Ok(UserList.GetValue(id));
        }
    }
}
