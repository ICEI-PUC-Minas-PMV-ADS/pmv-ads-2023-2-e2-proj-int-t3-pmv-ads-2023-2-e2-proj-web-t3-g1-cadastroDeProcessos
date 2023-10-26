using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Processos.Models;

namespace Processos.Controllers
{
    public class MenuTopoController : ControllerBase
    {

        [HttpGet]
        public IActionResult RenderizarTopo()
        {

            var builder = WebApplication.CreateBuilder();
            
            String html = "";
            
            using (SqlConnection connection = new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();

                string query = "Select * from USUARIO";

                html += "<DIV id='debug'>" + query + "</DIV>";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {




                        while (reader.Read())
                        {

                          

                        }
                    }
                }
            }



            html = "";
    

            return Content(html, "text/html");
        }



    }
}
