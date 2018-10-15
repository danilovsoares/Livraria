using Livraria.Domain.Livros.Commands;

namespace Livraria.Domain.Livros.Validations
{
    public class NovoLivroCommandValidation : LivroValidation<NovoLivroCommand>
    {
        public NovoLivroCommandValidation()
        {
            ValidateTitulo();
            ValidateDescricao();
            ValidateAutor();
            ValidateEditora();
            ValidateNumeroEdicao();
            ValidateAnoEdicao();
            ValidateISBN();
        }
    }
}
