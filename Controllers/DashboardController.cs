using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Web.Http.Cors;

namespace MeuMoocBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DashboardController : ControllerBase
    {
        [HttpGet("{id}")]
        public Dashboard Get(int id)
        {
            var dashboard = new Dashboard{
                TreinamentosProgresso =  
                    new List<TreinamentoProgresso> 
                    {
                        new TreinamentoProgresso 
                        {
                            Id = 1, 
                            TreinamentoNome = "docker", 
                            Progresso = 24
                        },
                        new TreinamentoProgresso 
                        {
                            Id = 2, 
                            TreinamentoNome = "ruby", 
                            Progresso = 98
                        }
                    }
            };

            return dashboard;
        }
    }
}
