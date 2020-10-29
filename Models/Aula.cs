using System;
using System.Collections.Generic;

namespace MeuMoocBack.Models
{
    public class Aula
    {
        public int Num { get; set; }
        public string Nome { get; set; }
        public VideoAula VideoAulaSendoExibida { get; set; }

        public Aula(int num, string nome, VideoAula videoAula)
        {
            this.Num = num;
            this.Nome = nome;
            this.VideoAulaSendoExibida = videoAula;
        }
    }
}
