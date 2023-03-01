using EditoraNovaGeracao.MVC.ViewModels.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EditoraNovaGeracao.MVC.ViewModels
{
    public class FornecedorViewModel : ViewModelBase
    {
        [Required(ErrorMessage = "Preencha o campo 'NOME'!")]
        [MaxLength(120, ErrorMessage = "Máximo {0} caracteres!")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres!")]
        [DisplayName("Nome do fornecedor")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo 'ENDEREÇO'!")]
        [MaxLength(180, ErrorMessage = "Máximo {0} caracteres!")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres!")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Preencha o campo 'TELEFONE'!")]
        [MaxLength(60, ErrorMessage = "Máximo {0} caracteres!")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres!")]
        public string Telefone { get; set; }

        public virtual IEnumerable<LivroViewModel> Livros { get; set; }
    }
}
