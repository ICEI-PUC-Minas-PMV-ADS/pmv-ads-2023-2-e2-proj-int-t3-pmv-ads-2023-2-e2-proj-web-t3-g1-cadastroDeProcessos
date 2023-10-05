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

    public class SpeedbuttonController : ControllerBase
    {

        public readonly AppDbContext _context;

        public SpeedbuttonController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Teste(String Tabela, String CampoBusca, String CampoExibicao, String CampoDestino, String ContenedorCampoExibicao, String Busca)
        {
            String html = "";

            Busca = Busca.Replace("'", "''");
           
            List<String> columnData = new List<String>();

            using (SqlConnection connection = new SqlConnection("Server=127.0.0.1;Database=processos;User Id=sa; Password=123456; TrustServerCertificate=True"))
            {
                connection.Open();


                string query = $"SELECT {CampoBusca}, {CampoExibicao} FROM {Tabela} WHERE {CampoExibicao} like '%{Busca}%'";

                html += query; 


                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        html += "<TABLE id='listaSpeedButton'><TR><TH>" + CampoBusca + "</TH><TH>" + CampoExibicao + "</TH></TR>";

                        while (reader.Read())
                        {

                            //reader.GetValue(reader.GetOrdinal("nome"));
                            // columnData.Add(reader.GetString(0) );


                            //html += String.Concat(html, "<TR><TD>" + reader.GetValue(reader.GetOrdinal(CampoBusca)) + "</TD><TD>" + reader.GetValue(reader.GetOrdinal(CampoExibicao)) + "</TD>" );

                            String b = "" + reader.GetValue(reader.GetOrdinal(CampoBusca));
                            String e = "" + reader.GetValue(reader.GetOrdinal(CampoExibicao));

                            html += "<TR><TD>" + b + "</TD><TD>" + e + "</TD><TD><a href='javascript:selecionarSpeedbutton(\"" + CampoDestino + "\", \"" + b + "\", \"" + ContenedorCampoExibicao + "\", \"" + e + "\")'>[selecionar]</a></TD></TR>";


                        }
                    }
                }
            }

            html += "</Table>";

            // Fazer algo com o valor obtido
            return Content(html, "text/html");
        }

    }
}
