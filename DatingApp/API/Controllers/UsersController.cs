using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;

        }

        /* Rota:
               api/users
           Return:
                lista de todos os usuarios
        */

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            //var users = _context.Users.ToList();

            return await _context.Users.ToListAsync();
        }

        /* Rota:
               api/users/{id}
           Return:
                usuario de id n
        */
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);

        }

        [HttpPost]
        public ActionResult PostUser(AppUser newUser)
        {
            // //var users = _context.Users.ToList();
            // try
            // {
            //    if(await _context.AddAsync(newUser))
            //    {

            //    }

            //     return BadRequest();
            // }
            // catch (Exception ex)
            // {
            //     return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao criar usuário!: {ex.Message}");
            // }
            return null;
        }




    }
}