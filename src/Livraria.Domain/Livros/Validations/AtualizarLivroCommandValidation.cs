using Livraria.Domain.Livros.Commands;

namespace Livraria.Domain.Livros.Validations
{
    public class AtualizarLivroCommandValidation : LivroValidation<AtualizarLivroCommand>
    {
        public AtualizarLivroCommandValidation()
        {
            ValidateId();
        }
    }
}
