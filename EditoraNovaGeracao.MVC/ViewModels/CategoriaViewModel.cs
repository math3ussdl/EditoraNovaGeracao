using EditoraNovaGeracao.MVC.ViewModels.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EditoraNovaGeracao.MVC.ViewModels
{
    public class CategoriaViewModel : ViewModelBase
    {
        [Required(ErrorMessage = "Preencha o campo 'NOME'!")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres!")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres!")]
        [DisplayName("Nome da categoria")]
        public string Nome { get; set; }

        public virtual IEnumerable<LivroViewModel> Livros { get; set; }
    }
}
