using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Processos.Models;
namespace Processos.Controllers
{


    [ApiController]
    [Route("api/setoresusuario")]
    public class SetoresUsuarioController : Controller
    {

        public bool usuarioTemSetor(String cpfUsuario, String codigoSetor)
        {
            var builder = WebApplication.CreateBuilder();

            using (SqlConnection connection = new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();

                string query = $"SELECT * FROM USUARIO_TEM_SETOR where cpfUsuario='{cpfUsuario}' and codigoSetor={codigoSetor}";


                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        if (reader.Read())
                        {

                            return true;

                        
                        }
                    }
                }
            }

            return false;

        }

        [HttpGet]
        public IActionResult Listar(String cpfUsuario)
        {

            var builder = WebApplication.CreateBuilder();
            String html = "";

            cpfUsuario = cpfUsuario.Replace("'", "''");

            int quantidade = 0;
            using (SqlConnection connection = new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();


                string query = $"SELECT * FROM SETOR";

                html += "<DIV id='debug'>" + query + "</div>";


                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        html += "<TABLE class='table'><TR><TH>&nbsp;</TH><TH>Setor</TH></TR>";

                        while (reader.Read())
                        {

                            //reader.GetValue(reader.GetOrdinal("nome"));
                            // columnData.Add(reader.GetString(0) );


                            //html += String.Concat(html, "<TR><TD>" + reader.GetValue(reader.GetOrdinal(CampoBusca)) + "</TD><TD>" + reader.GetValue(reader.GetOrdinal(CampoExibicao)) + "</TD>" );

                            String codigoSetor = "" + reader.GetValue(reader.GetOrdinal("codigoSetor"));
                            String nome = "" + reader.GetValue(reader.GetOrdinal("nome"));

                            html += "<TR><TD><input type='checkbox' id='setor_" + codigoSetor + "' value='S' ";
                            
                            if(usuarioTemSetor(cpfUsuario, codigoSetor))
                            {
                                html += " checked ";
                            }

                            html += "></TD><TD>" + nome + "</TD></TR>";


                            html += "<SCRIPT>$('#setor_" + codigoSetor + "').change(function(){vincularUsuarioSetor(valor('cpfUsuario'), " + codigoSetor + ")});</SCRIPT>";

                           

                            quantidade++;
                        }
                    }
                }
            }

            html += "</Table>";


            if (quantidade == 0)
            {
                html = "<DIV id='registroNaoEncontrado'>Nenhum setor foi cadastrado ainda</DIV>";
            }

            // Fazer algo com o valor obtido
            return Content(html, "text/html");
        }


    }
}
