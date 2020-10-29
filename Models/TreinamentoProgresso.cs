using System;
using System.Collections.Generic;

namespace MeuMoocBack.Models
{
    public class TreinamentoProgresso
    {
        //public int Id { get; set; }
        public Treinamento Treinamento { get; set; }
        public int Progresso { get; set; }

        public TreinamentoProgresso(/*int id, */Treinamento treinamento, int progresso)
        {
            /*this.Id = id;*/
            this.Treinamento = treinamento;
            this.Progresso = progresso;            
        }
    }
}
