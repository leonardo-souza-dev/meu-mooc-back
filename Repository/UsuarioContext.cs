using System.Linq;
using System.Collections.Generic;
using MeuMoocBack.Models;
using System.Threading.Tasks;

namespace MeuMoocBack.Repository
{

    public class UsuarioContext
    {
        private readonly List<Usuario> Usuarios = new List<Usuario>();

        public UsuarioContext()
        {
            var usuario1 = new Usuario(1, "Joao", "7700123456");
            usuario1.IngressarEmTreinamento(new Treinamento(1, "Percy"));
            usuario1.IngressarEmTreinamento(new Treinamento(2, "xUnit"));
            this.Usuarios.Add(usuario1);

            var usuario2 = new Usuario(2, "Maria", "7700555666");
            usuario2.IngressarEmTreinamento(new Treinamento(2, "Cypress"));
            this.Usuarios.Add(usuario2);
        }

        public async Task<Usuario> Obter(int id)
        {
            var result = this.Usuarios.FirstOrDefault(x => x.Id == id);
            return await Task.FromResult<Usuario>(result);
        }

        public async Task<List<Usuario>> ObterTodos()
        {
            return await Task.FromResult<List<Usuario>>(this.Usuarios);
        }
    }
}