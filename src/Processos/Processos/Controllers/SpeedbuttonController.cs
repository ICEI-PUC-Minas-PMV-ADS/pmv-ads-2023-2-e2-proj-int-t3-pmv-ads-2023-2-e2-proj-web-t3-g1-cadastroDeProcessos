using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Processos.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Net.Mime.MediaTypeNames;



// https://localhost:44388/api/Speedbutton/?A=1


namespace Processos.Controllers
{

    [ApiController]
    [Route("api/speedbutton")]

    public class SpeedbuttonController : Controller
    {

        public readonly AppDbContext _context;

        public SpeedbuttonController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Teste(String Tabela, String CampoBusca, String CampoExibicao, String CampoDestino)
        {
            String html;

            html = "";

            List<String> columnData = new List<String>();

            using (SqlConnection connection = new SqlConnection("Server=127.0.0.1;Database=processos;User Id=sa; Password=123456; TrustServerCertificate=True"))
            {
                connection.Open();
                string query = "SELECT * FROM SETOR";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            reader.GetValue(reader.GetOrdinal("nome"));

                           // columnData.Add(reader.GetString(0) );

                            html = String.Concat(html, reader.GetValue(reader.GetOrdinal("codigoSetor")));

                        }
                    }
                }
            }


            // Fazer algo com o valor obtido
            return Content($"Valor do parâmetro 'A': {html}");
        }

    }
}
