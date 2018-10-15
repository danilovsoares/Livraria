using Livraria.Domain.Core.Models;
using Livraria.Domain.MethodExtension;

namespace Livraria.Domain.Livros.Models
{
    public class Livro : Entity
    {
        public Livro(string titulo, string descricao, string autor, string editora, int numeroEdicao, int anoEdicao, string iSBN)
        {
            Titulo = titulo;
            Descricao = descricao;
            Autor = autor;
            Editora = editora;
            NumeroEdicao = numeroEdicao;
            AnoEdicao = anoEdicao;
            ISBN = iSBN;
        }

        protected Livro() { }

        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public string Autor { get; private set; }
        public string Editora { get; private set; }
        public int NumeroEdicao { get; private set; }
        public int AnoEdicao { get; private set; }
        public string ISBN { get; private set; }

        public void AtualizarInformacoes(string titulo, string descricao, string autor, string editora, int numeroEdicao, int anoEdicao, string iSBN)
        {
            if (titulo.IsNotNullOrEmpty())
                Titulo = titulo;
            if (descricao.IsNotNullOrEmpty())
                Descricao = descricao;
            if (autor.IsNotNullOrEmpty())
                Autor = autor;
            if (editora.IsNotNullOrEmpty())
                Editora = editora;
            if (numeroEdicao.IsNotNullOrEmpty())
                NumeroEdicao = numeroEdicao;
            if (anoEdicao.IsNotNullOrEmpty())
                AnoEdicao = anoEdicao;
            if (iSBN.IsNotNullOrEmpty())
                ISBN = iSBN;
        }
    }
}
