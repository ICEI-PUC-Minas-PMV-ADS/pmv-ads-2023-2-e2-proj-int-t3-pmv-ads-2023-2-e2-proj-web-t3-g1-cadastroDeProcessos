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
    public class DashboardController : ControllerBase
    {


        [HttpGet]
        public IActionResult Retornar(String Tabela)
        {
            String html = "";


            using (SqlConnection connection = new SqlConnection("Server=127.0.0.1;Database=processos;User Id=sa; Password=123456; TrustServerCertificate=True"))
            {
                connection.Open();

                string query = $"SELECT COUNT(*)  FROM {Tabela}";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {


                        if (reader.Read())
                        {

                            html = "" + reader.GetValue(reader.GetOrdinal(0));

                        }
                    }
                }
            }


            // Fazer algo com o valor obtido
            return Content(html, "text/html");
        }


    }
}
