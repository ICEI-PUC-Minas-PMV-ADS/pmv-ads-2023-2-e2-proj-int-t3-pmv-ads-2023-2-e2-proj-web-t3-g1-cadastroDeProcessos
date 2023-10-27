using Azure.Core;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Http;

namespace  Processos;
	public class Funcoes
	{

        HttpContext _httpContext;

        public Funcoes(HttpContext httpContext)
        {
             _httpContext = httpContext;
        }


        public String LoginDaSessao()
		{
            return _httpContext.Session.GetString("login");
        } 

	}



