using AutoMapper;
using EditoraNovaGeracao.Application.Interfaces;
using EditoraNovaGeracao.Domain.Entities;
using EditoraNovaGeracao.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EditoraNovaGeracao.MVC.Controllers
{
    public class LivrosController : Controller
    {
        private readonly ILivroAppService _livroApp;
        private readonly ICategoriaAppService _categoriaApp;
        private readonly IFornecedorAppService _fornecedorApp;

        public LivrosController(
            ILivroAppService livroAppService,
            ICategoriaAppService categoriaService,
            IFornecedorAppService fornecedorService)
        {
            _livroApp = livroAppService;
            _categoriaApp = categoriaService;
            _fornecedorApp = fornecedorService;
        }

        private LivroViewModel GetViewModelById(Guid id)
        {
            var livro = _livroApp.GetById(id);
            return Mapper.Map<Livro, LivroViewModel>(livro);
        }

        // GET: Livros
        public ActionResult Index()
        {
            return View(Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroViewModel>>(_livroApp.GetAll()));
        }

        // GET: Livros/Details/<GUID>
        public ActionResult Details(Guid id)
        {
            return View(GetViewModelById(id));
        }

        // GET: Livros/Create
        public ActionResult Create()
        {
            ViewBag.CategoriaId = new SelectList(_categoriaApp.GetAll(), "Id", "Nome");
            ViewBag.FornecedorId = new SelectList(_fornecedorApp.GetAll(), "Id", "Nome");

            return View();
        }

        // POST: Livros/Create
        [HttpPost]
        public ActionResult Create(LivroViewModel livro)
        {
            if (ModelState.IsValid)
            {
                _livroApp.Add(Mapper.Map<LivroViewModel, Livro>(livro));
                return RedirectToAction("Index");
            }

            ViewBag.CategoriaId = new SelectList(_categoriaApp.GetAll(), "Id", "Nome", livro.CategoriaId);
            ViewBag.FornecedorId = new SelectList(_fornecedorApp.GetAll(), "Id", "Nome", livro.FornecedorId);
            return View(livro);
        }

        // GET: Livros/Edit/<GUID>
        public ActionResult Edit(Guid id)
        {
            var livroViewModel = GetViewModelById(id);
            ViewBag.CategoriaId = new SelectList(_categoriaApp.GetAll(), "Id", "Nome", livroViewModel.CategoriaId);
            ViewBag.FornecedorId = new SelectList(_fornecedorApp.GetAll(), "Id", "Nome", livroViewModel.FornecedorId);
            return View(livroViewModel);
        }

        // POST: Livros/Edit/<GUID>
        [HttpPost]
        public ActionResult Edit(LivroViewModel livro)
        {
            if (ModelState.IsValid)
            {
                _livroApp.Update(Mapper.Map<LivroViewModel, Livro>(livro));
                return RedirectToAction("Index");
            }

            ViewBag.CategoriaId = new SelectList(_categoriaApp.GetAll(), "Id", "Nome", livro.CategoriaId);
            ViewBag.FornecedorId = new SelectList(_fornecedorApp.GetAll(), "Id", "Nome", livro.FornecedorId);
            return View(livro);
        }

        // GET: Livros/Delete/<GUID>
        public ActionResult Delete(Guid id)
        {
            return View(GetViewModelById(id));
        }

        // POST: Livros/Delete/<GUID>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _livroApp.Remove(_livroApp.GetById(id));
            return RedirectToAction("Index");
        }
    }
}
