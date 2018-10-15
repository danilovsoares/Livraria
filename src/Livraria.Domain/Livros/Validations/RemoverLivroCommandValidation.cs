using Livraria.Domain.Livros.Commands;

namespace Livraria.Domain.Livros.Validations
{
    public class RemoverLivroCommandValidation : LivroValidation<RemoverLivroCommand>
    {
        public RemoverLivroCommandValidation()
        {
            ValidateId();
        }
    }
}
