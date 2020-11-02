using System;
using System.Collections.Generic;

namespace MeuMoocBack.Models
{
    public class Dashboard
    {
        public Usuario Usuario { get; set; }
        public List<TreinamentoProgresso> TreinamentosProgresso { get; set; } = new List<TreinamentoProgresso>();
    }
}
