using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Processos.Controllers
{


    [ApiController]
    [Route("api/consultapublica")]

    public class ConsultaPublicaController : ControllerBase
    {

        private int nm = 1;

        public String quadroMovimentacao(String codigoProcesso)
        {

            String b = "<TABLE id='movproc'>";

            var builder = WebApplication.CreateBuilder();

            using (SqlConnection connection = new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();

                String sql = $"SELECT m.*, s.nome FROM MOVIMENTACAO m inner join SETOR s on s.codigoSetor = m.codigoSetorLocalizacao WHERE m.codigoProcesso = '{codigoProcesso}'";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            b += "<TR><TD>Movimentação #" + nm +  "<BR>Data/Hora: " + reader.GetValue(reader.GetOrdinal("dataHora")) + "<BR>";

                            b += "Setor: " + reader.GetValue(reader.GetOrdinal("nome")) + "</TD>";

       


                            nm++;
                        }
                    }
                }
            }

            return b + "</table>";

        }

        [HttpGet]
        public IActionResult consultar(String cpfCnpjInteressado, String codigoProcesso)
        {

            String b = "Processo não encontrado.";

            List<string> sl = new List<string>();

            var builder = WebApplication.CreateBuilder();

            using (SqlConnection connection = new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();

                String sql = "SELECT p.*, i.nome as nomeInteressado, tp.nomeTipoProcesso FROM PROCESSO p INNER JOIN INTERESSADO i on p.codigoInteressado = i.codigoInteressado INNER JOIN TIPO_PROCESSO tp on tp.codigoTipoProcesso = p.codigoTipoProcesso  WHERE cpfCnpjInteressado='" + cpfCnpjInteressado + "' AND p.codigoProcesso = '" + codigoProcesso + "'";

                using (SqlCommand command = new SqlCommand(sql, connection)) 
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        if (reader.Read())
                        {

                            sl.Add($"Processo Código {codigoProcesso}");
                            sl.Add($"Data/Hora: " + reader.GetValue(reader.GetOrdinal("dataHora")));
                            sl.Add($"Interessado: " + reader.GetValue(reader.GetOrdinal("nomeInteressado")));
                            sl.Add($"Tipo de Processo: " + reader.GetValue(reader.GetOrdinal("nomeTipoProcesso")));

                            b = "<DIV id='contenedorProcesso'>*** INFORMACOES SOBRE PROCESSO ***<BR>";
                            foreach (string str in sl){
                                b += "<DIV>" + str + "</DIV>";
                            }

                            b += "</div>";

                            b += quadroMovimentacao(codigoProcesso);


                        }
                    }
                }
            }


            // Fazer algo com o valor obtido
            return Content(b, "text/html");
        }
    }
}
