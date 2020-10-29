using System;
using System.Collections.Generic;
using MeuMoocBack.Models;
using MeuMoocBack.Repository;

namespace MeuMoocBack.DbContext
{
    public class DbFake
    {
        public UsuarioContext Usuarios = new UsuarioContext();
        public List<TreinamentoProgresso> TreinamentoProgressos = new List<TreinamentoProgresso>();
    }
}
