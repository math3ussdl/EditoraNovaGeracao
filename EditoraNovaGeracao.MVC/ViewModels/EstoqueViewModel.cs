using EditoraNovaGeracao.MVC.ViewModels.Common;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EditoraNovaGeracao.MVC.ViewModels
{
    public class EstoqueViewModel : ViewModelBase
    {
        [Required(ErrorMessage = "Preencha o campo 'QUANTIDADE'!")]
        [DisplayName("Quantidade de livros")]
        public int Quantidade { get; set; }

        public Guid LivroId { get; set; }
        public virtual LivroViewModel Livro { get; set; }
    }
}
