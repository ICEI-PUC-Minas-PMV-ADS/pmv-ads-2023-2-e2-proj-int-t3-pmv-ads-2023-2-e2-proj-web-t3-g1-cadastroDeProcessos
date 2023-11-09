using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Processos.Controllers
{

	[ApiController]
	[Route("api/excluirmovimentacao")]

	public class ExcluirMovimentacao : ControllerBase
	{


        [HttpGet]
		public IActionResult excluir(String codigoMovimentacao)
		{

            var builder = WebApplication.CreateBuilder();

            using (SqlConnection connection = new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();

				SqlCommand command2 = new SqlCommand($"DELETE FROM MOVIMENTACAO WHERE codigoMovimentacao = {codigoMovimentacao}", connection);

				using (SqlDataReader reader2 = command2.ExecuteReader())
				{

				}

            }

			// Fazer algo com o valor obtido
			return Content("001 - Excluido", "text/html");
		}

	}
}
