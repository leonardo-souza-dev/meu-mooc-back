using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuMoocBack.Models
{
    public class Usuario
    {
        public int Id { get; }
        public string Nome { get;  }
        public string Matricula { get; }
        public List<Treinamento> Treinamentos { get; } = new List<Treinamento>();

        public Usuario(int id, string nome, string Matricula)
        {
            this.Id = id;
            this.Nome = nome;
            this.Matricula = Matricula;
        }

        public void IngressarEmTreinamento(Treinamento treinamento)
        {
            this.Treinamentos.Add(treinamento);
        }
    }
}
