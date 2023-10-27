using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Processos.Controllers
{

    [ApiController]
    [Route("api/sair")]
    public class sairController : ControllerBase
    {
        [HttpGet]
        public IActionResult sair()
        {

            HttpContext.Session.Remove("login");

            // Fazer algo com o valor obtido
            return Content("001 - Saiu do sistema", "text/html");

        }

    }
}
