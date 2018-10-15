using System.ComponentModel.DataAnnotations;

namespace Livraria.Application.Livros.ViewModels.Request
{
    public class SalvarLivroViewModel
    {
        [Required(ErrorMessage = "Título é obrigatório")]
        [MinLength(2,ErrorMessage = "Título deve ter entre 2 e 50 caracteres")]
        [MaxLength(50, ErrorMessage = "Título deve ter entre 2 e 50 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatório")]
        [MinLength(2, ErrorMessage = "Descrição deve ter entre 2 e 255 caracteres")]
        [MaxLength(255, ErrorMessage = "Descrição deve ter entre 2 e 255 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Autor é obrigatório")]
        [MinLength(2, ErrorMessage = "Autor deve ter entre 2 e 50 caracteres")]
        [MaxLength(50, ErrorMessage = "Autor deve ter entre 2 e 50 caracteres")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "Editora é obrigatório")]
        [MinLength(2, ErrorMessage = "Editora deve ter entre 2 e 50 caracteres")]
        [MaxLength(50, ErrorMessage = "Editora deve ter entre 2 e 50 caracteres")]
        public string Editora { get; set; }

        [Required(ErrorMessage = "Número edição é obrigatório")]
        public int NumeroEdicao { get; set; }

        [Required(ErrorMessage = "Ano da edição é obrigatório")]
        public int AnoEdicao { get; set; }

        [Required(ErrorMessage = "ISBN é obrigatório")]
        [MinLength(2, ErrorMessage = "ISBN deve ter entre 2 e 50 caracteres")]
        [MaxLength(50, ErrorMessage = "ISBN deve ter entre 2 e 50 caracteres")]
        public string ISBN { get; set; }
    }
}
