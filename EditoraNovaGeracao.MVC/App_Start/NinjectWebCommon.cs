using EditoraNovaGeracao.Shared.Communication.Interfaces;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(EditoraNovaGeracao.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(EditoraNovaGeracao.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace EditoraNovaGeracao.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Application.Common;
    using Application.Interfaces;
    using Application;
    using Domain.Services.Common;
    using Domain.Interfaces.Services;
    using Domain.Services;
    using Infrastructure.Data.Repositories.Common;
    using Domain.Interfaces.Repositories;
    using Infrastructure.Data.Repositories;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IResourcesCommunicationBase<,>)).To(typeof(AppServiceBase<,>));
            kernel.Bind<ICategoriaAppService>().To(typeof(CategoriaAppService));
            kernel.Bind<IEstoqueAppService>().To(typeof(EstoqueAppService));
            kernel.Bind<IFornecedorAppService>().To(typeof(FornecedorAppService));
            kernel.Bind<ILivroAppService>().To(typeof(LivroAppService));

            kernel.Bind(typeof(IServiceCommunication<,>)).To(typeof(ServiceBase<,>));
            kernel.Bind<ICategoriaService>().To(typeof(CategoriaService));
            kernel.Bind<IEstoqueService>().To(typeof(EstoqueService));
            kernel.Bind<IFornecedorService>().To(typeof(FornecedorService));
            kernel.Bind<ILivroService>().To(typeof(LivroService));

            kernel.Bind(typeof(IRepositoryCommunication<,>)).To(typeof(RepositoryBase<,>));
            kernel.Bind<ICategoriaRepository>().To(typeof(CategoriaRepository));
            kernel.Bind<IEstoqueRepository>().To(typeof(EstoqueRepository));
            kernel.Bind<IFornecedorRepository>().To(typeof(FornecedorRepository));
            kernel.Bind<ILivroRepository>().To(typeof(LivroRepository));
        }
    }
}
