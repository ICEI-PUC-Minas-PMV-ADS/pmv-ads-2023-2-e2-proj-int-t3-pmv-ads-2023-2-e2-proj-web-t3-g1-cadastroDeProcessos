using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Processos.Controllers
{

    [ApiController]
    [Route("api/processopodesertramitado")]

    public class ProcessoPodeSerTramitado : ControllerBase
    {


        [HttpGet]
        public IActionResult entrar(String codigoProcesso, String codigoSetorDestino)
        {

         
            String b = "000 - Não";
            var builder = WebApplication.CreateBuilder();

            using (SqlConnection connection = new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();

                String sql = $"SELECT * FROM USUARIO WHERE cpfUsuario='{cpfUsuario}' AND senha='{Senha}' ";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        if (reader.Read())
                        {

                            Response.Cookies.Append("login", cpfUsuario);

                            HttpContext.Session.SetString("login", cpfUsuario);

                            b = "001 - Logado com sucesso";

                        }
                    }
                }
            }


            // Fazer algo com o valor obtido
            return Content(b, "text/html");
        }

    }
}
