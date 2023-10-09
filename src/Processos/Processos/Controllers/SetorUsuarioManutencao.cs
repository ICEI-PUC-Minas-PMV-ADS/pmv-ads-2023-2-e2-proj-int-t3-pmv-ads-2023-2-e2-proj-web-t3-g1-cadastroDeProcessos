using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Humanizer;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Processos.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Net.Mime.MediaTypeNames;


namespace Processos.Controllers
{
  

        [ApiController]
        [Route("api/setorusuariomanutencao")]

        public class SetorUsuarioManutencaoController : ControllerBase
        {

            [HttpGet]
            public IActionResult Alterar(String cpfUsuario, int codigoSetor, String Acao)
            {

                var builder = WebApplication.CreateBuilder();
     

      
                using (SqlConnection connection = new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")))
                {
                    connection.Open();

                    String sql = "";

                    if(Acao == "Remover")
                    {
                        sql = $"DELETE FROM USUARIO_TEM_SETOR WHERE cpfUsuario = '{cpfUsuario}' AND codigoSetor={codigoSetor}";

                    }

                    if (Acao == "Adicionar")
                    {
                        sql = $"INSERT INTO USUARIO_TEM_SETOR (cpfUsuario, codigoSetor) values ('{cpfUsuario}', {codigoSetor})";

                    }
                 

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {

                               
                            }
                        }

                    }

                }

                // Fazer algo com o valor obtido
                return Content($"001 - Diz que foi {cpfUsuario}, {codigoSetor}, {Acao}", "text/html");
            }


        }

    }
