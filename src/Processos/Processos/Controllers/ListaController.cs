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
                s.Add("i.nome as 'Nome'");
                s.Add("tp.nomeTipoProcesso as 'Tipo'");
                s.Add("s.nome as 'Setor'");
                s.Add("p.dataHora as 'Data/Hora'");
                s.Add("p.resumo as 'Resumo'");


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
                                    Cab += "<TH>" + reader.GetName(i) + "</TH>";
                                }

                                Cab += "<TH>&nbsp;</TH></TR></THEAD>";

                            }

                            Dat += "<TR>";

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Dat += "<TD>" + reader.GetValue(i) + "</TD>";
                            }

                            Dat += "<TD><a href = '/" + Rota + "/Edit/" + reader.GetValue(reader.GetOrdinal("PK")) + "'>[Editar]</a><a href='/" + Rota + "/Delete/" + reader.GetValue(reader.GetOrdinal("PK")) + "'>[Excluir]</a></TH>";

                            Dat += "</TR>";

                        }
                    }
                }
            }


            if(Cab == "")
            {
                Cab = "<DIV id='registroNaoEncontrado'>Nenhum registro encontrado para o cadastro ou busca informada.</DIV>";
            }

            return Content(html + Cab + Dat, "text/html");
        }

    }


}

