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
    [Route("api/Guia_Remessa")]

    public class Guia_RemessaController : ControllerBase
    {

        String html;


        [HttpGet]
        public IActionResult Exibir(String CodigoProcessos)
        {

            var builder = WebApplication.CreateBuilder();
           

            using (SqlConnection connection = new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();



                // Capa do processo
                using (SqlCommand command = new SqlCommand("SELECT * FROM PROCESSO p INNER JOIN INTERESSADO i on i.codigoInteressado = p.codigoInteressado INNER JOIN SETOR s on p.codigoSetor=s.codigoSetor INNER JOIN TIPO_PROCESSO tp on p.codigoTipoProcesso = tp.codigoTipoProcesso WHERE codigoProcesso=" + CodigoProcessos, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        if (reader.Read())
                        {

                            html = "Dados do processo";

                        }
                    }
                }



                //Movimentação
                using (SqlCommand command = new SqlCommand("SELECT * FROM MOVIMENTACAO m INNER JOIN SETOR s on s.codigoSetor = m.codigoSetorLocalizacao INNER JOIN USUARIO u on u.cpfUsuario = m.cpfUsuarioTramite WHERE m.codigoProcesso=" + CodigoProcessos + " ORDER BY codigoMovimentacao", connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            html = "Dados da movimentação";


                        }
                    }
                }


            }


            return Content(html, "text/html");
        }


    }

}
