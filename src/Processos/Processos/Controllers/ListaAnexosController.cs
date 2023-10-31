using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace Processos.Controllers
{

    [ApiController]
    [Route("api/listaanexos")]


    public class ListaAnexosController : ControllerBase
    {



        [HttpGet]
        public IActionResult ListarAnexos(int codigoProcesso)
        {
            String html = "";
            int quantidade = 0;
            var builder = WebApplication.CreateBuilder();


            using (SqlConnection connection = new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();

                string query = $"SELECT * FROM ANEXO_PROCESSO ap WHERE ap.codigoProcesso = {codigoProcesso}";

                html += "<DIV id='debug'>" + query + "</div>";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        html += "<TABLE class='table'><TR><TH>Código</TH><TH>Nome</TH><TH>Data Hora</TH><TH>&nbsp;</TH></TR>";

                        while (reader.Read())
                        {

                            html += "<TR><TD>" + reader.GetValue(reader.GetOrdinal("codigoAnexo")) + "</TD><TD>" + reader.GetValue(reader.GetOrdinal("nomeAnexo")) + "</TD><TD>" + reader.GetValue(reader.GetOrdinal("dataHora")) + $"</TD><TD style='width:1px'><a href='/api/downloadanexo/" + reader.GetValue(reader.GetOrdinal("codigoAnexo"))  + "' target='_blank'><img style='width:32px' src='/img/Download.png'></a></TD></TR>";
                            quantidade++;
                        }
                    }
                }
            }

            html += $"<TR><TD colspan='6' style='text-align:right'><a href='/AnexoProcesso/Create/?codProcesso={codigoProcesso}'><img src='/img/Adicionar.png'></a></TD></TR>";
            html += "</Table>";


            if (quantidade == 0)
            {
                html = "<DIV id='registroNaoEncontrado'>Nenhum anexo foi enviado para este processo.</DIV>" + html;
            }

            // Fazer algo com o valor obtido
            return Content(html, "text/html");
        }



    }

}
