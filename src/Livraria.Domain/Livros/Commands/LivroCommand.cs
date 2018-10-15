﻿using Livraria.Domain.Core.Commands;
using System;

namespace Livraria.Domain.Livros.Commands
{
    public abstract class LivroCommand : Command
    { 
        public Guid Id { get; protected set; }
        public string Titulo { get; protected set; }
        public string Descricao { get; protected set; }
        public string Autor { get; protected set; }
        public string Editora { get; protected set; }
        public int NumeroEdicao { get; protected set; }
        public int AnoEdicao { get; protected set; }
        public string ISBN { get; protected set; }
    }
}
