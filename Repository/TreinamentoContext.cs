using System.Linq;
using System.Collections.Generic;
using MeuMoocBack.Models;
using System.Threading.Tasks;

namespace MeuMoocBack.Repository
{

    public class TreinamentoContext
    {
        private readonly List<Treinamento> Treinamentos = new List<Treinamento>();

        public TreinamentoContext()
        {
            var treinamento1 = new Treinamento(1, "Percy");
            treinamento1.Aulas.Add(new Aula(1, "configurando ambiente", new VideoAula("https://www.w3schools.com/tags/movie.mp4")));
            treinamento1.Aulas.Add(new Aula(2, "implementacao", new VideoAula("https://www.w3schools.com/tags/movie.mp4")));
            treinamento1.Aulas.Add(new Aula(3, "conclusoes", new VideoAula("https://www.w3schools.com/tags/movie.mp4")));
            this.Treinamentos.Add(treinamento1);

            var treinamento2 = new Treinamento(1, "xUnit");
            treinamento2.Aulas.Add(new Aula(2, "instalando dependencias", new VideoAula("https://www.w3schools.com/tags/movie.mp4")));
            this.Treinamentos.Add(treinamento2);
        }

        public async Task<Treinamento> Obter(int id)
        {
            return await Task.FromResult<Treinamento>(this.Treinamentos.FirstOrDefault(x => x.Id == id));
        }

        public async Task<List<Treinamento>> ObterTodos()
        {
            return await Task.FromResult<List<Treinamento>>(this.Treinamentos);
        }
    }
}