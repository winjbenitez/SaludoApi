using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SaludoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaludoController : ControllerBase
    {
        // GET: api/Saludo
        [HttpGet]
        public IActionResult GetSaludo()
        {
            return Ok(new
            {
                mensaje = "Hola Mundo desde C# .NET 10"
            });
        }

        // GET: api/Saludo/Josue
        [HttpGet("{nombre}")]
        public IActionResult GetSaludoNombre(string nombre)
        {
            return Ok(new
            {
                mensaje = $"Hola {nombre}, bienvenido a mi API REST"
            });
        }
    }
}
