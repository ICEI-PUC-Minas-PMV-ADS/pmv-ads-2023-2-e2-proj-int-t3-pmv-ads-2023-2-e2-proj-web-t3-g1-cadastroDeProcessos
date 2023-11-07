using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Processos.Controllers
{

    [ApiController]
    [Route("api/downloadanexo")]

    
    public class DownloadController : ControllerBase
    {

        [HttpGet("{codigoAnexo}")]
        public IActionResult DownloadFile(String codigoAnexo)
        {

            var builder = WebApplication.CreateBuilder();


            using (SqlConnection connection = new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();

                string query = $"SELECT * FROM ANEXO_PROCESSO ap WHERE ap.codigoAnexo = {codigoAnexo}";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        
                        if (reader.Read())
                        {

                            String filename = "" + reader.GetValue(reader.GetOrdinal("nomeAnexo"));
                                                        
                            String uploadPath = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: false).Build().GetValue<string>("AppSettings:uploadPath") + "/" + codigoAnexo;

                            if (System.IO.File.Exists(uploadPath))
                            {
                                return File(System.IO.File.OpenRead(uploadPath), "application/octet-stream", filename);
                            }

                        }

                    }

                }

            }




            // Handle the case where the file does not exist or an error occurred.
            return NotFound();

        }

    }

}
