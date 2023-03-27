

using Microsoft.AspNetCore.Mvc;
using SaudeAPI.model;

namespace SaudeAPI.Controllers
{
     [ApiController]
     [Route("api/[controller]")]

    public class UsuarioController : ControllerBase
    {
     private static List<usuario> Usuarios(){
       return new List<usuario>{
          new usuario {Nome = "Daniel", Id = 1 , DataNascimento = new DateTime(2004,3,1)}
       };
     }

     // Primeiro End Point para Teste de Funcionamento da API
         [HttpGet]
         public IActionResult Get(){
            return Ok(Usuarios());
         }


         [HttpPost]
         public IActionResult Post(usuario usuario){
            var usuarios = Usuarios();
            usuarios.Add(usuario);
            return Ok(usuarios);
         }

    }
}