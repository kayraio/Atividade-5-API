using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Exo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetosController : ControllerBase
    {
        // Simulação de dados
        private static List<string> projetos = new List<string> { "Projeto A", "Projeto B" };

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(projetos);
            }
            catch (Exception)
            {
                return StatusCode(500, "Erro ao obter projetos.");
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] string novoProjeto)
        {
            try
            {
                projetos.Add(novoProjeto);
                return StatusCode(201, "Projeto criado com sucesso.");
            }
            catch (Exception)
            {
                return StatusCode(500, "Erro ao criar projeto.");
            }
        }
    }
}
