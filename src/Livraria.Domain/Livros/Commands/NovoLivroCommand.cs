using Livraria.Domain.Livros.Validations;
using System;

namespace Livraria.Domain.Livros.Commands
{
    public class NovoLivroCommand : LivroCommand
    {
        public NovoLivroCommand(string titulo, string descricao, string autor, string editora, int numeroEdicao, int anoEdicao, string iSBN)
        {
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
            ValidationResult = new NovoLivroCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
