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
    public class DashboardsController : ControllerBase
    {
        public readonly UsuarioContext _usuarioContext = new UsuarioContext();
        
        [HttpGet]
        [Route("usuario/{id:int}")]
        public async Task<Dashboard> Get(int id)
        {
            Usuario usuario = await _usuarioContext.Obter(id);

            Usuario usuario2 = new Usuario(1, "Leo", "78978");
            usuario2.Treinamentos.ForEach(x => x.Aulas.Add(new Aula(1, "", new VideoAula(""))));

            var treinamentosProgresso = new List<TreinamentoProgresso>();
            usuario.Treinamentos.ForEach(x => treinamentosProgresso.Add(new TreinamentoProgresso(x, 10)));

            var dashboard = new Dashboard
            {
                Usuario = usuario,
                TreinamentosProgresso = treinamentosProgresso
            };

            return dashboard;
        }
    }
}
