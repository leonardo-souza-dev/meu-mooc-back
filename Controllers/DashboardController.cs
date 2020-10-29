using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Web.Http.Cors;
using MeuMoocBack.DbContext;
using MeuMoocBack.Repository;
using MeuMoocBack.Models;

namespace MeuMoocBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DashboardController : ControllerBase
    {
        public readonly UsuarioContext _usuarioContext = new UsuarioContext();
        
        [HttpGet("{id}")]
        public Dashboard Get(int id)
        {
            var usuario = _usuarioContext.Obter(id);
            var treinamentosProgresso = new List<TreinamentoProgresso>();
            usuario.Treinamentos.ForEach(x => treinamentosProgresso.Add(new TreinamentoProgresso(x, 10)));

            var dashboard = new Dashboard
            {
                UsuarioId = usuario.Id,
                TreinamentosProgresso = treinamentosProgresso
            };

            return dashboard;
        }
    }
}
