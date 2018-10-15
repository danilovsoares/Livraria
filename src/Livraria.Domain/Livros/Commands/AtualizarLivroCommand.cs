using Livraria.Domain.Livros.Validations;
using System;

namespace Livraria.Domain.Livros.Commands
{
    public class AtualizarLivroCommand : LivroCommand
    {
        public AtualizarLivroCommand(Guid id, string titulo, string descricao, string autor, string editora, int numeroEdicao, int anoEdicao, string iSBN)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            Autor = autor;
            Editora = editora;
            NumeroEdicao = numeroEdicao;
            AnoEdicao = anoEdicao;
            ISBN = iSBN;
        }

        public override bool IsValid()
        {
            ValidationResult = new AtualizarLivroCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
