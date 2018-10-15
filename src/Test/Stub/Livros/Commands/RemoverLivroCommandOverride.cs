using Livraria.Domain.Livros.Commands;
using System;

namespace Test.Stub.Livros.Commands
{
    public class RemoverLivroCommandOverride
    {
        public static RemoverLivroCommand RemoverLivroCommand()
        {
            return new RemoverLivroCommand(Guid.NewGuid());
        }

        public static RemoverLivroCommand RemoverLivroCommandComIdNULL()
        {
            return new RemoverLivroCommand(default(Guid));
        }
    }
}
