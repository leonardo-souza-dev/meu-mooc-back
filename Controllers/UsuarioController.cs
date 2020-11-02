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
    public class UsuariosController : ControllerBase
    {
        public readonly UsuarioContext UsuarioContext = new UsuarioContext();

        [HttpGet]
        [Route("todos")]
        public async Task<List<Usuario>> Get()
        {
            return await UsuarioContext.ObterTodos();
        }

        [HttpGet("{id:int}")]
        public async Task<Usuario> Get(int id)
        {
            return await UsuarioContext.Obter(id);
        }
    }

    public class Paginacao
    {
        public int NumPag { get; set; }

    }
}
