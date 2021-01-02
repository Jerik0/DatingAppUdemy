using API.data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        // get the DbContext class that serves as the middle layer for interacting with the DB.
        private readonly DataContext _context;

        // inject it into the constructor
        public UsersController(DataContext context)
        {
            _context = context; // Tadaaaaa
        }

        // API ENDPOINTS WOOT WOOT
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }
        
        // api/users/2 (or whichever id)
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}
