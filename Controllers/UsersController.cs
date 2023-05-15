using DatingApp_API.Data;
using DatingApp_API.Entities;
using Microsoft.AspNetCore.Mvc;


namespace DatingApp_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // GET /api/users
    public class UsersController
    {
        private readonly MainDbContext _context;

        public UsersController(MainDbContext context) 
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            var users = _context.Users.ToList();

            return users;
        }
        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUser(int id)
        {
            return _context.Users.Find(id);
            
        }
    }
}
