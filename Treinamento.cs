using System;
using System.Collections.Generic;

namespace MeuMoocBack
{
    public class Treinamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Aula> Aulas { get; set; }
    }

    public class Aula
    {
        public int Num { get; set; }
        public string Nome { get; set; }
        public VideoAula VideoAulaSendoExibida { get; set; }
    }

    public class VideoAula
    {
        public int Num { get; set; }
        public string Nome { get; set; }
        public string Uri { get; set; }
    }
}
