using Livraria.Domain.Livros.Models;

namespace Test.Stub.Livros.Models
{
    public class LivroStub
    {
        public static Livro Livro()
        {
            return new Livro(
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
