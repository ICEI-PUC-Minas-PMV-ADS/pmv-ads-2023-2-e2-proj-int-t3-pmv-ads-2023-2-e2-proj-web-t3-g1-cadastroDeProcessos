using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Processos.Controllers
{

	[ApiController]
	[Route("api/login")]

	public class LoginController : ControllerBase
	{

		public void criarUsuarioAutomaticamente(String cpfUsuario, String Senha)
		{

            var builder = WebApplication.CreateBuilder();

            using (SqlConnection connection = new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();

                String sql = "SELECT * FROM USUARIO ";

                using (SqlCommand command = new SqlCommand(sql, connection)) 
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

						if (reader.Read())
						{

						}
						else
						{
							reader.Close();

							// Não tem usuário.
							SqlCommand command2 = new SqlCommand($"INSERT INTO USUARIO (cpfusuario, nome, senha, administrativo) values ('{cpfUsuario}', 'Usuário {cpfUsuario}', '{Senha}', '1')", connection);

							using (SqlDataReader reader2 = command2.ExecuteReader())
							{
								// Deve ter criado.

							}
						}

                    }
                }
            }
        }


        [HttpGet]
		public IActionResult entrar(String cpfUsuario, String Senha)
		{

			criarUsuarioAutomaticamente(cpfUsuario, Senha);

			String b = "000 - Login ou senha invalidos";
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
