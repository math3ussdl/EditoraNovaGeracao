using EditoraNovaGeracao.MVC.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EditoraNovaGeracao.MVC.ViewModels
{
    public class LivroViewModel : ViewModelBase
    {
        [Required(ErrorMessage = "Preencha o campo 'TÍTULO'!")]
        [MaxLength(120, ErrorMessage = "Máximo {0} caracteres!")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres!")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Preencha o campo 'AUTOR'!")]
        [MaxLength(60, ErrorMessage = "Máximo {0} caracteres!")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres!")]
        [DisplayName("Nome do autor")]
        public string Autor { get; set; }

        [DisplayName("Ano de lançamento")]
        public int Ano { get; set; }

        [Required(ErrorMessage = "Preencha o campo 'PREÇO'!")]
        [DisplayName("Preço")]
        public decimal Preco { get; set; }

        public Guid CategoriaId { get; set; }
        public virtual CategoriaViewModel Categoria { get; set; }

        public Guid FornecedorId { get; set; }
        public virtual FornecedorViewModel Fornecedor { get; set; }

        public virtual IEnumerable<EstoqueViewModel> Estoques { get; set; }
    }
}
