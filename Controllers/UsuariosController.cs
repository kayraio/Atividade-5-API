using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Exo.WebApi.Models;

namespace Exo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        // Simulando dados em memória
        private static List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario { Id = 1, Email = "email1@email.com", Senha = "1234" },
            new Usuario { Id = 2, Email = "email2@email.com", Senha = "1234" }
        };

        // GET: api/usuarios
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(usuarios);
        }

        // GET: api/usuarios/3
       [HttpGet("{id}")]
public IActionResult GetById(int id)
{
    var usuario = usuarios.FirstOrDefault(u => u.Id == id);

    if (usuario == null)
    {
        return NotFound("Usuário não encontrado.");
    }

    return Ok(usuario);
}

    }
}
