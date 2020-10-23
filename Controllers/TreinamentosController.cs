using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Web.Http.Cors;

namespace meu_mooc_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TreinamentosController : ControllerBase
    {
        [HttpGet("")]
        public IEnumerable<TreinamentoPreview> Get()
        {
            return new List<TreinamentoPreview> {
                new TreinamentoPreview{ Id = 1, Nome = "nUnit"},
                new TreinamentoPreview{ Id = 2, Nome = "cypress"}
            };
        }
        
        [HttpGet("{id:int}")]
        public Treinamento Get([FromQuery]int id)
        {
            return new Treinamento 
            { 
                Id = 1, 
                Nome = "nUnit",
                Aulas = new List<Aula>
                {
                    new Aula
                    {
                        Num = 1,
                        Nome = "Configurando ambiente"
                    },
                    new Aula
                    {
                        Num = 2,
                        Nome = "Hello world"
                    },
                    new Aula
                    {
                        Num = 3,
                        Nome = "Conclusão"
                    }
                }
            };
        }
    }
}
