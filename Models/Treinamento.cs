using System;
using System.Collections.Generic;

namespace MeuMoocBack.Models
{
    public class Treinamento
    {
        public int Id { get; }
        public string Nome { get; }
        public List<Aula> Aulas { get; set; } = new List<Aula>();

        public Treinamento(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;            
        }

        public void SetarAulas(List<Aula> aulas)
        {
            this.Aulas.AddRange(aulas);
        }
    }
}
