using Livraria.Domain.Livros.Commands;

namespace Test.Stub.Livros.Commands
{
    public class NovoLivroCommandOverride
    {

        public static NovoLivroCommand NovoLivroCommand()
        {
            return new NovoLivroCommand(
                "ASP.NET Core MVC",
                "Aplicações modernas em conjunto com o Entity Framework",
                "Everton Coimbra de Araújo",
                "Casa do Código",
                1,
                2018,
                "9788594188458");
        }

        public static NovoLivroCommand NovoLivroCommandComTituloNULL()
        {
            return new NovoLivroCommand(
                null,
                "Aplicações modernas em conjunto com o Entity Framework",
                "Everton Coimbra de Araújo",
                "Casa do Código",
                1,
                2018,
                "9788594188458");
        }

        public static NovoLivroCommand NovoLivroCommandComDescricaoNULL()
        {
            return new NovoLivroCommand(
                "ASP.NET Core MVC",
                null,
                "Everton Coimbra de Araújo",
                "Casa do Código",
                1,
                2018,
                "9788594188458");
        }

        public static NovoLivroCommand NovoLivroCommandComAutorNULL()
        {
            return new NovoLivroCommand(
                "ASP.NET Core MVC",
                "Aplicações modernas em conjunto com o Entity Framework",
                null,
                "Casa do Código",
                1,
                2018,
                "9788594188458");
        }

        public static NovoLivroCommand NovoLivroCommandComEditoraNULL()
        {
            return new NovoLivroCommand(
                "ASP.NET Core MVC",
                "Aplicações modernas em conjunto com o Entity Framework",
                "Everton Coimbra de Araújo",
                null,
                1,
                2018,
                "9788594188458");
        }

        public static NovoLivroCommand NovoLivroCommandComNumeroEdicaoZero()
        {
            return new NovoLivroCommand(
                "ASP.NET Core MVC",
                "Aplicações modernas em conjunto com o Entity Framework",
                "Everton Coimbra de Araújo",
                "Casa do Código",
                default(int),
                2018,
                "9788594188458");
        }

        public static NovoLivroCommand NovoLivroCommandComAnoEdicaoZero()
        {
            return new NovoLivroCommand(
                "ASP.NET Core MVC",
                "Aplicações modernas em conjunto com o Entity Framework",
                "Everton Coimbra de Araújo",
                "Casa do Código",
                1,
                default(int),
                "9788594188458");
        }

        public static NovoLivroCommand NovoLivroCommandComISBNNULL()
        {
            return new NovoLivroCommand(
                "ASP.NET Core MVC",
                "Aplicações modernas em conjunto com o Entity Framework",
                "Everton Coimbra de Araújo",
                "Casa do Código",
                1,
                2018,
                null);
        }
    }
}
