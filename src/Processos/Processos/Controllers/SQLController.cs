using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
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
    [Route("api/sql")]

    public class SQLController : ControllerBase
    {

        [HttpGet]
        public IActionResult Teste(String SQL)
        {
            String b = "";
            var builder = WebApplication.CreateBuilder();

            using (SqlConnection connection = new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(SQL, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                       
                        if (reader.Read())
                        {

                            b = "" + reader.GetValue(0);
                            

                        }
                    }
                }
            }


            // Fazer algo com o valor obtido
            return Content(b, "text/html");
        }

    }
}
