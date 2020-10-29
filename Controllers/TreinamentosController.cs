using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Web.Http.Cors;
using MeuMoocBack.Models;
using MeuMoocBack.Repository;

namespace MeuMoocBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TreinamentoController : ControllerBase
    {
        public readonly TreinamentoContext TreinamentoContext = new TreinamentoContext();

        [HttpGet]
        public List<Treinamento> Get()
        {
            return TreinamentoContext.ObterTodos();
        }

        [HttpGet("{id}")]
        public Treinamento Get(int id)
        {
            return TreinamentoContext.Obter(id);
        }
    }
}
