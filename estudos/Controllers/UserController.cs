using Microsoft.AspNetCore.Mvc;
using estudos.Services;
using estudos.Models;
using Microsoft.AspNetCore.Authorization;
using System;
using estudos.Data;
using Microsoft.EntityFrameworkCore;

namespace estudos.Controllers
{
    [Route("users")]
    public class UserController : Controller
    {
        [HttpPost]
        [Route("")]
        [AllowAnonymous]
        public async Task<ActionResult<User>> Post(
            [FromServices] DataContext context,
            [FromBody] User model)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                context.Users.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            catch (Exception)
            {
                return BadRequest(new { message = "Não foi possivel criar usuário" });
            }
        }


        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> Authenticate(
            [FromBody] DataContext context,
            [FromBody] User model) 
        { 
            var user = await context.Users
                .AsNoTracking()
                .Where( x => x.Name == model.Name && x.Password == model.Password )
                .FirstOrDefaultAsync();

            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = TokenService.GenerateToken(user);

            return new
            {
                user = user,
                token = token,
            };
        }
    }
}
