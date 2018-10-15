using Test.Stub.Livros.Commands;
using Xunit;

namespace Test.Domain.Livros.Commands
{
    public class NovoLivroCommandTest
    {
        [Fact, Trait("Command", "Command/Livro/NovoLivroCommand")]
        public void Command_Valido_Nao_Deve_Exibir_Erro()
        {
            var command = NovoLivroCommandOverride.NovoLivroCommand();

            command.IsValid();
            var validationResult = command.ValidationResult;
            Assert.True(validationResult.Errors.Count == default(int));
        }

        [Fact, Trait("Command", "Command/Livro/NovoLivroCommand")]
        public void Command_Com_Titulo_NULL_Deve_Cair_No_Valid_E_Exibir_Erro()
        {
            var command = NovoLivroCommandOverride.NovoLivroCommandComTituloNULL();

            command.IsValid();
            var validationResult = command.ValidationResult;
            Assert.Contains(validationResult.Errors, v => v.PropertyName.Contains("Titulo"));
        }

        [Fact, Trait("Command", "Command/Livro/NovoLivroCommand")]
        public void Command_Com_Descricao_NULL_Deve_Cair_No_Valid_E_Exibir_Erro()
        {
            var command = NovoLivroCommandOverride.NovoLivroCommandComDescricaoNULL();

            command.IsValid();
            var validationResult = command.ValidationResult;
            Assert.Contains(validationResult.Errors, v => v.PropertyName.Contains("Descricao"));
        }

        [Fact, Trait("Command", "Command/Livro/NovoLivroCommand")]
        public void Command_Com_Autor_NULL_Deve_Cair_No_Valid_E_Exibir_Erro()
        {
            var command = NovoLivroCommandOverride.NovoLivroCommandComAutorNULL();

            command.IsValid();
            var validationResult = command.ValidationResult;
            Assert.Contains(validationResult.Errors, v => v.PropertyName.Contains("Autor"));
        }

        [Fact, Trait("Command", "Command/Livro/NovoLivroCommand")]
        public void Command_Com_Editora_NULL_Deve_Cair_No_Valid_E_Exibir_Erro()
        {
            var command = NovoLivroCommandOverride.NovoLivroCommandComEditoraNULL();

            command.IsValid();
            var validationResult = command.ValidationResult;
            Assert.Contains(validationResult.Errors, v => v.PropertyName.Contains("Editora"));
        }

        [Fact, Trait("Command", "Command/Livro/NovoLivroCommand")]
        public void Command_Com_Numero_Edicao_Zero_Deve_Cair_No_Valid_E_Exibir_Erro()
        {
            var command = NovoLivroCommandOverride.NovoLivroCommandComNumeroEdicaoZero();

            command.IsValid();
            var validationResult = command.ValidationResult;
            Assert.Contains(validationResult.Errors, v => v.PropertyName.Contains("NumeroEdicao"));
        }


        [Fact, Trait("Command", "Command/Livro/NovoLivroCommand")]
        public void Command_Com_Ano_Edicao_Zero_Deve_Cair_No_Valid_E_Exibir_Erro()
        {
            var command = NovoLivroCommandOverride.NovoLivroCommandComAnoEdicaoZero();

            command.IsValid();
            var validationResult = command.ValidationResult;
            Assert.Contains(validationResult.Errors, v => v.PropertyName.Contains("AnoEdicao"));
        }

        [Fact, Trait("Command", "Command/Livro/NovoLivroCommand")]
        public void Command_Com_ISBN_NULL_Deve_Cair_No_Valid_E_Exibir_Erro()
        {
            var command = NovoLivroCommandOverride.NovoLivroCommandComISBNNULL();

            command.IsValid();
            var validationResult = command.ValidationResult;
            Assert.Contains(validationResult.Errors, v => v.PropertyName.Contains("ISBN"));
        }
    }
}
