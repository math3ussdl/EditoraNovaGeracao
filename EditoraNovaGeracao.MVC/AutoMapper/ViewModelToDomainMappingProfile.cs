using AutoMapper;
using EditoraNovaGeracao.Domain.Entities;
using EditoraNovaGeracao.MVC.ViewModels;

namespace EditoraNovaGeracao.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<CategoriaViewModel, Categoria>();
            Mapper.CreateMap<EstoqueViewModel, Estoque>();
            Mapper.CreateMap<FornecedorViewModel, Fornecedor>();
            Mapper.CreateMap<LivroViewModel, Livro>();
        }
    }
}
