﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Livraria.Application.Livros.ViewModels.Request
{
    public class AtualizarLivroViewModel
    {
        [Required(ErrorMessage = "Id é obrigatório")]
        public Guid Id { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string Autor { get; set; }

        public string Editora { get; set; }

        public int NumeroEdicao { get; set; }

        public int AnoEdicao { get; set; }

        public string ISBN { get; set; }
    }
}
