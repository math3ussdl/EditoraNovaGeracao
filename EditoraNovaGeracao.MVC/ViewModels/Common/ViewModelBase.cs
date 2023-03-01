using System;
using System.ComponentModel.DataAnnotations;

namespace EditoraNovaGeracao.MVC.ViewModels.Common
{
    public class ViewModelBase
    {
        [Key]
        public Guid Id { get; set; }

        [ScaffoldColumn(false)]
        public DateTimeOffset DataCriacao { get; set; }

        [ScaffoldColumn(false)]
        public DateTimeOffset DataAtualizacao { get; set; }
    }
}