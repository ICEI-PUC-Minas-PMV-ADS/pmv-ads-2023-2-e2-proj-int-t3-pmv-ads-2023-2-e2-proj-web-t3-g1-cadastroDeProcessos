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

            var builder = WebApplication.CreateBuilder();
            String html = "";
            int quantidade = 0;

            Busca = Busca.Replace("'", "''");
           
            List<String> columnData = new List<String>();

            using (SqlConnection connection = new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();


                string query = $"SELECT {CampoBusca}, {CampoExibicao} FROM {Tabela} WHERE {CampoExibicao} like '%{Busca}%'";

                html += "<DIV id='debug'>" + query + "</div>"; 


                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        html += "<TABLE class='table'><TR><TH>" + CampoBusca + "</TH><TH>" + CampoExibicao + "</TH></TR>";

                        while (reader.Read())
                        {

                            //reader.GetValue(reader.GetOrdinal("nome"));
                            // columnData.Add(reader.GetString(0) );


                            //html += String.Concat(html, "<TR><TD>" + reader.GetValue(reader.GetOrdinal(CampoBusca)) + "</TD><TD>" + reader.GetValue(reader.GetOrdinal(CampoExibicao)) + "</TD>" );

                            String b = "" + reader.GetValue(reader.GetOrdinal(CampoBusca));
                            String e = "" + reader.GetValue(reader.GetOrdinal(CampoExibicao));

                            html += "<TR><TD>" + b + "</TD><TD>" + e + "</TD><TD><a href='javascript:selecionarSpeedbutton(\"" + CampoDestino + "\", \"" + b + "\", \"" + ContenedorCampoExibicao + "\", \"" + e + "\")'>[selecionar]</a></TD></TR>";

                            quantidade++;

                        }
                    }
                }
            }

            html += "</Table>";


            if (quantidade == 0)
            {
                html = "<DIV id='registroNaoEncontrado'>Nenhum registro encontrado para o cadastro ou busca informada.</DIV>";
            }

            // Fazer algo com o valor obtido
            return Content(html, "text/html");
        }

    }
}
