using Livraria.Domain.Livros.Commands;
using System;

namespace Test.Stub.Livros.Commands
{
    public class AtualizarLivroCommandOverride
    {
        public static AtualizarLivroCommand AtualizarLivroCommand()
        {
            return new AtualizarLivroCommand(
                Guid.NewGuid(),
                "ASP.NET Core MVC",
                "Aplicações modernas em conjunto com o Entity Framework",
                "Everton Coimbra de Araújo",
                "Casa do Código",
                1,
                2018,
                "9788594188458");
        }

        public static AtualizarLivroCommand AtualizarLivroCommandComIdNULL()
        {
            return new AtualizarLivroCommand(
                default(Guid),
                 "ASP.NET Core MVC",
                "Aplicações modernas em conjunto com o Entity Framework",
                "Everton Coimbra de Araújo",
                "Casa do Código",
                1,
                2018,
                "9788594188458");
        }
    }
}
