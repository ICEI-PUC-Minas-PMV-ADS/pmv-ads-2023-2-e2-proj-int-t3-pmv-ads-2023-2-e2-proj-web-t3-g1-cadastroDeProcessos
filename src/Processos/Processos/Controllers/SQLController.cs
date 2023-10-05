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


            using (SqlConnection connection = new SqlConnection("Server=127.0.0.1;Database=processos;User Id=sa; Password=123456; TrustServerCertificate=True"))
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
