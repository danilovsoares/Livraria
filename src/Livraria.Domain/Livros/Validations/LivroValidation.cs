using FluentValidation;
using Livraria.Domain.Livros.Commands;
using System;

namespace Livraria.Domain.Livros.Validations
{
    public abstract class LivroValidation<T> : AbstractValidator<T> where T : LivroCommand
    {
        protected void ValidateId()
        {
            RuleFor(r => r.Id)
                .NotEqual(Guid.Empty)
                .WithMessage("LivroId é obrigatório");
        }

        protected void ValidateTitulo()
        {
            RuleFor(r => r.Titulo)
                .NotEmpty().WithMessage("Título é obrigatório")
                .Length(2, 50).WithMessage("Título deve ter entre 2 e 50 caracteres"); 
        }

        protected void ValidateDescricao()
        {
            RuleFor(r => r.Descricao)
              .NotEmpty().WithMessage("Descrição é obrigatório")
              .Length(2, 255).WithMessage("Descrição deve ter entre 2 e 255 caracteres");
        }

        protected void ValidateAutor()
        {
            RuleFor(r => r.Autor)
               .NotEmpty().WithMessage("Autor é obrigatório")
               .Length(2, 50).WithMessage("Autor deve ter entre 2 e 50 caracteres");
        }
        protected void ValidateEditora()
        {
            RuleFor(r => r.Editora)
               .NotEmpty().WithMessage("Editora é obrigatório")
               .Length(2, 50).WithMessage("Editora deve ter entre 2 e 50 caracteres");
        }

        protected void ValidateNumeroEdicao()
        {
            RuleFor(r => r.NumeroEdicao)
                .NotEqual(default(int)).WithMessage("Número Edição é obrigatório");
        }

        protected void ValidateAnoEdicao()
        {
            RuleFor(r => r.AnoEdicao)
              .NotEqual(default(int)).WithMessage("Ano Edição é obrigatório");
        }

        protected void ValidateISBN()
        {
            RuleFor(r => r.ISBN)
              .NotEmpty().WithMessage("ISBN é obrigatório")
              .Length(2, 50).WithMessage("ISBN deve ter entre 2 e 50 caracteres");
        }
    }
}
