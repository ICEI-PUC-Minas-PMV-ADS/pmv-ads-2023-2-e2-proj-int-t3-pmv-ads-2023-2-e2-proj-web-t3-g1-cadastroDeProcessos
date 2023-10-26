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
    [Route("api/processosetor")]

    public class DashboardProcessosPorSetor : ControllerBase
    {

        [HttpGet]
        public IActionResult Teste(String SQL)
        {
            String b = "<TABLE>";
            var builder = WebApplication.CreateBuilder();

            using (SqlConnection connection = new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(SQL, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            
                            b = b + "<TR><TD style='width:100%; text-align:left'>" + reader.GetValue(0) + "</TD><TD>" + reader.GetValue(1) + "</TD></TR>";


                        }
                    }
                }
            }

            b = b + "</TABLE>";

            // Fazer algo com o valor obtido
            return Content(b, "text/html");
        }

    }
}
