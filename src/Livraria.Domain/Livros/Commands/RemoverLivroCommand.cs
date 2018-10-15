using Livraria.Domain.Livros.Validations;
using System;

namespace Livraria.Domain.Livros.Commands
{
    public class RemoverLivroCommand : LivroCommand
    {
        public RemoverLivroCommand(Guid id)
        {
            Id = id;
        }

        public override bool IsValid()
        {
            ValidationResult = new RemoverLivroCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
