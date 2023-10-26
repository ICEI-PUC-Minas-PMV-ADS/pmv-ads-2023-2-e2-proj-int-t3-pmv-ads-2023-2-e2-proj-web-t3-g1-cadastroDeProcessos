using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Processos.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Net.Mime.MediaTypeNames;

namespace Processos.Controllers
{

    [ApiController]
    [Route("api/listamovimentacao")]


    public class ListaMovimentacaoController : ControllerBase
    {

      

        [HttpGet]
        public IActionResult ListarMovimentacoes(int codigoProcesso)
        {
            String html = "";
            int quantidade = 0;
            var builder = WebApplication.CreateBuilder();


            using (SqlConnection connection = new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();


                string query = $"SELECT s.nome as nomeSetor, * FROM MOVIMENTACAO m INNER JOIN SETOR s on s.codigoSetor = m.codigoSetorLocalizacao INNER JOIN USUARIO u on u.cpfUsuario = m.cpfUsuarioTramite WHERE m.codigoProcesso = {codigoProcesso} ORDER BY codigoMovimentacao";

                html += "<DIV id='debug'>" + query + "</div>";


                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        html += "<TABLE class='table'><TR><TH>Código</TH><TH>Movimento</TH><TH>Data Hora</TH><TH>CPF</TH><TH>Setor</TH><TH>&nbsp;</TH></TR>";

                        while (reader.Read())
                        {

                            quantidade++;

                            html += "<TR><TD>" + reader.GetValue(reader.GetOrdinal("codigoMovimentacao")) + "</TD><TD>" + quantidade + "</TD><TD>" + reader.GetValue(reader.GetOrdinal("dataHora")) + "</TD><TD>" + reader.GetValue(reader.GetOrdinal("cpfUsuarioTramite")) + "</TD><TD>" + reader.GetValue(reader.GetOrdinal("nomeSetor")) + "</TD><TD style='text-align:right'>";


                        
                            html += "<a href='/Movimentacao/Edit/" + reader.GetValue(reader.GetOrdinal("codigoMovimentacao")) + "'><img src='/img/Editar.png'></a>";
                            
                            html += "</TD></TR>";

                           

                        }
                    }
                }
            }

            html += $"<TR><TD colspan='6' style='text-align:right'><a href='/Movimentacao/Create/?codProcesso={codigoProcesso}'><img src='/img/Adicionar.png'></a></TD></TR>";
            html += "</Table>";


            if (quantidade == 0)
            {
                html = "<DIV id='registroNaoEncontrado'>Nenhuma movimentação foi realizada ainda.</DIV>" + html;
            }

            // Fazer algo com o valor obtido
            return Content(html, "text/html");
        }



    }

}
