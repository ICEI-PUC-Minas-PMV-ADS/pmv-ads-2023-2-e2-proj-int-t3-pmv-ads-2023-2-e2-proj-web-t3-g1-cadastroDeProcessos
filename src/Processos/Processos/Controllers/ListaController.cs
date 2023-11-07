using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;

namespace Processos.Controllers
{

    [ApiController]
    [Route("api/Lista")]


    public class ListaController : ControllerBase
    {

        private readonly IWebHostEnvironment _webHostEnvironment;


        public ListaController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }


        public String GeradorSQL(String Tabela, String Busca)
        {

            String SQL = "";

            List<string> s = new List<string>();
            List<string> b = new List<string>();


            if (Tabela == "FLUXO")
            {

                SQL = "SELECT [S] FROM FLUXO f INNER JOIN TIPO_PROCESSO tp on f.codigoTipoProcesso = tp.codigoTipoProcesso inner join SETOR s1 on s1.codigoSetor = f.codigoSetorOrigem inner join SETOR s2 on s2.codigoSetor = f.codigoSetorDestino WHERE ";

                s.Add("f.codigoFluxo as PK");
                b.Add($"f.codigoFluxo like '%{Busca}%'");

                s.Add("tp.nomeTipoProcesso as 'Tipo Processo'");
                b.Add($"tp.nomeTipoProcesso like '%{Busca}%'");

                s.Add("s1.nome as 'Setor Origem'");
                b.Add($"s1.nome like '%{Busca}%'");

                s.Add("s2.nome as 'Setor Destino'");
                b.Add($"s2.nome like '%{Busca}%'");

            }

            if (Tabela == "SETOR")
            {
                SQL = "SELECT [S] FROM SETOR s WHERE ";

                s.Add("s.codigoSetor as PK");
                s.Add("s.nome as 'Nome'");
                b.Add($"s.nome like '%{Busca}%'");
                b.Add($"s.codigoSetor like '%{Busca}%'");

            }

            if (Tabela == "TIPO_PROCESSO")
            {
                SQL = "SELECT [S] FROM TIPO_PROCESSO tp WHERE ";

                s.Add("tp.codigoTipoProcesso as PK");
                s.Add("tp.nomeTipoProcesso as 'Nome'");
                b.Add($"tp.nomeTipoProcesso like '%{Busca}%'");
                b.Add($"tp.codigoTipoProcesso like '%{Busca}%'");

            }



            if (Tabela == "INTERESSADO")
            {
                SQL = "SELECT [S] FROM INTERESSADO i WHERE ";

                s.Add("i.codigoInteressado as PK");
                s.Add("i.cpfCnpjInteressado as 'CPF/CNPJ'");
                s.Add("i.nome as 'Nome'");

                b.Add($"i.nome like '%{Busca}%'");
                b.Add($"i.codigoInteressado like '%{Busca}%'");
                b.Add($"i.cpfCnpjInteressado like '%{Busca}%'");

            }

            if (Tabela == "USUARIO")
            {
                SQL = "SELECT [S] FROM USUARIO u WHERE ";

                s.Add("u.cpfUsuario as PK");
                s.Add("u.nome as 'Nome'");
                b.Add($"u.cpfUsuario like '%{Busca}%'");
                b.Add($"u.nome like '%{Busca}%'");

            }

            if (Tabela == "PROCESSO")
            {
                SQL = "SELECT [S] FROM PROCESSO p INNER JOIN TIPO_PROCESSO tp on tp.codigoTipoProcesso = p.codigoTipoProcesso INNER JOIN INTERESSADO i on i.codigoInteressado = p.codigoInteressado inner join SETOR s on s.codigoSetor = p.codigoSetor WHERE ";

                s.Add("p.codigoProcesso as PK");
                s.Add("p.dataHora as 'Data/Hora'");
                s.Add("i.nome as 'Interessado'");
                s.Add("tp.nomeTipoProcesso as 'Tipo'");
                s.Add("s.nome as 'Setor'");                
                s.Add("p.resumo as 'Resumo'");

                s.Add(" CASE WHEN situacaoProcesso = 1 THEN 'Em andamento' ELSE 'Finalizado' END AS 'Situação'");



                b.Add($"p.codigoProcesso like '%{Busca}%'");
                b.Add($"s.nome like '%{Busca}%'");
                b.Add($"i.nome like '%{Busca}%'");
                b.Add($"p.resumo like '%{Busca}%'");
                b.Add($"p.assunto like '%{Busca}%'");
                b.Add($"tp.nomeTipoProcesso like '%{Busca}%'");

            }


            String S = "";
          

            foreach (string busca in s)
            {
                S += busca + ", ";                
            }
            S = Regex.Replace(S, @", $", "");


            SQL = SQL.Replace("[S]", S);


            foreach (string condicional in b)
            {
                SQL += " OR " + condicional + " ";
            }

            SQL = SQL.Replace("WHERE  OR ", " WHERE ");


            return SQL;

        }

        [HttpGet]
        public IActionResult Lista(String Rota, String Tabela, String Busca)
        {

            var builder = WebApplication.CreateBuilder();
            Busca = Busca.Replace("'", "''");
            String html = "";
            String Cab = "";
            String Dat = "";
            int cc = 0;

            String csv = "";

            using (SqlConnection connection = new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")))
            {

                connection.Open();

                string query = GeradorSQL(Tabela, Busca);

                html += "<DIV id='debug'>" + query + "</DIV>";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            if (Cab == "")
                            {

                                Cab = "<TABLE class='table'><THEAD><TR>";

                                for (int i = 0; i < reader.FieldCount; i++)
                                {
									
									String c = reader.GetName(i);
									
									if(c == "PK"){
										c = "Código";
									}
									
                                    Cab += "<TH>" + c + "</TH>";

                                    csv += "\"" + c + "\";";

                                }

                                csv += "\r\n";

                                Cab += "<TH>&nbsp;</TH></TR></THEAD>";

                            }

                            Dat += "<TR>";

                            cc = 0;
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Dat += "<TD>" + reader.GetValue(i) + "</TD>";

                                csv += "\"" + reader.GetValue(i) + "\";";

                                cc++;
                            }
                            csv += "\r\n";

                            Dat += "<TD style='text-align:center; width:100px'><a href = '/" + Rota + "/Edit/" + reader.GetValue(reader.GetOrdinal("PK")) + "'><img src='/img/Editar.png'></a><a href='/" + Rota + "/Delete/" + reader.GetValue(reader.GetOrdinal("PK")) + "'><img src='/img/Excluir.png'></a></TH>";

                            Dat += "</TR>";

                        }
                    }
                }
            }

            if(Cab == "")
            {
                Cab = "<DIV id='registroNaoEncontrado'>Nenhum registro encontrado para o cadastro ou busca informada.</DIV>";
            }
            else
            {

                DateTime currentDateTime = DateTime.Now;

                // Format the date and time as a string in a specific format.
                string formattedDateTime = currentDateTime.ToString("yyyyMMddHHmmss") + ".csv";

                //  String tmpdir = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: false).Build().GetValue<string>("AppSettings:tmpdir") + formattedDateTime;

                String tmpdir = _webHostEnvironment.WebRootPath + "/Dados/" + formattedDateTime; 

                using (var fileStream = new FileStream(tmpdir, FileMode.Create))
                {

                    try
                    {

                        using (StreamWriter outputFile = new StreamWriter(fileStream))
                        {
                            outputFile.Write(csv);
                        }
                        
                                                
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }

                }


                Dat = Dat + "<TR><TD colspan='" + cc + "'>&nbsp;</TD><TD style='text-align:center; width:100px'><a href='/Dados/" + formattedDateTime + "' target='_blank'><img src='/img/Excel.png'></a></TD></TR>";

                Dat = Dat + "</TABLE>";

            }

            return Content(html + Cab + Dat, "text/html");
        }

    }


}

