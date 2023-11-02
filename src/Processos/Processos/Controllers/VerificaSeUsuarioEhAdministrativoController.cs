
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Processos.Controllers
{

    [ApiController]
    [Route("api/vsa")]
    public class VerificaSeUsuarioEhAdministrativoController : ControllerBase
    {


        public String vsa()
        {

            
            
            String cpfUsuario = "";
            String b = "000 - ";

            Funcoes f = new Funcoes(this.HttpContext);
            cpfUsuario = f.LoginDaSessao();


            var builder = WebApplication.CreateBuilder();

            using (SqlConnection connection = new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();

                String sql = $"SELECT * FROM USUARIO WHERE cpfUsuario={cpfUsuario} AND administrativo = 1";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            b = "001 - ";
                        }
                    }
                }
            }

            return b;

        }


    }
}
