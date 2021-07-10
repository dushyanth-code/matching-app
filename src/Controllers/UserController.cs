using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using src.Data;
using src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UserController : ControllerBase
    {
        private readonly Mycontext _dbcontext;
        public UserController(Mycontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsersAsync()
        {
            return await _dbcontext.Users.ToListAsync();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<AppUser>> GetUserByIdAsync(int id)
        {
            return await _dbcontext.Users.FindAsync(id);
        }

    }
}
