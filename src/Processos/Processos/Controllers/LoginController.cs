using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Processos.Controllers
{

	[ApiController]
	[Route("api/login")]

	public class LoginController : ControllerBase
	{

		[HttpGet]
		public IActionResult entrar(String cpfUsuario, String Senha)
		{
			String b = "000 - Login ou senha invalidos";
			var builder = WebApplication.CreateBuilder();

			using (SqlConnection connection = new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")))
			{
				connection.Open();

				String sql = "SELECT * FROM USUARIO WHERE cpfUsuario='" + cpfUsuario + "'";

                using (SqlCommand command = new SqlCommand(sql, connection)) //AND senha='{Senha}'
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
