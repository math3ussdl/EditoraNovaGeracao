using AutoMapper;
using EditoraNovaGeracao.Application.Interfaces;
using EditoraNovaGeracao.Domain.Entities;
using EditoraNovaGeracao.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EditoraNovaGeracao.MVC.Controllers
{
    public class EstoquesController : Controller
    {
        private readonly IEstoqueAppService _estoqueApp;
        private readonly ILivroAppService _livroApp;

        public EstoquesController(IEstoqueAppService service, ILivroAppService livroService)
        {
            _estoqueApp = service;
            _livroApp = livroService;
        }

        private EstoqueViewModel GetViewModelById(Guid id)
        {
            var estoque = _estoqueApp.GetById(id);
            return Mapper.Map<Estoque, EstoqueViewModel>(estoque);
        }

        // GET: Estoques
        public ActionResult Index()
        {
            return View(Mapper.Map<IEnumerable<Estoque>, IEnumerable<EstoqueViewModel>>(_estoqueApp.GetAll()));
        }

        // GET: Estoques/Details/<GUID>
        public ActionResult Details(Guid id)
        {
            return View(GetViewModelById(id));
        }

        // GET: Estoques/Create
        public ActionResult Create()
        {
            ViewBag.LivroId = new SelectList(_livroApp.GetAll(), "Id", "Titulo");

            return View();
        }

        // POST: Estoques/Create
        [HttpPost]
        public ActionResult Create(EstoqueViewModel estoque)
        {
            if (ModelState.IsValid)
            {
                _estoqueApp.Add(Mapper.Map<EstoqueViewModel, Estoque>(estoque));
                return RedirectToAction("Index");
            }

            ViewBag.LivroId = new SelectList(_livroApp.GetAll(), "Id", "Titulo", estoque.LivroId);

            return View(estoque);
        }

        // GET: Estoques/Edit/<GUID>
        public ActionResult Edit(Guid id)
        {
            var estoqueViewModel = GetViewModelById(id);

            ViewBag.LivroId = new SelectList(_livroApp.GetAll(), "Id", "Titulo", estoqueViewModel.LivroId);

            return View(estoqueViewModel);
        }

        // POST: Estoques/Edit/<GUID>
        [HttpPost]
        public ActionResult Edit(EstoqueViewModel estoque)
        {
            if (ModelState.IsValid)
            {
                _estoqueApp.Update(Mapper.Map<EstoqueViewModel, Estoque>(estoque));
                return RedirectToAction("Index");
            }

            ViewBag.LivroId = new SelectList(_livroApp.GetAll(), "Id", "Titulo", estoque.LivroId);

            return View(estoque);
        }

        // GET: Estoques/Delete/<GUID>
        public ActionResult Delete(Guid id)
        {
            return View(GetViewModelById(id));
        }

        // POST: Estoques/Delete/<GUID>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _estoqueApp.Remove(_estoqueApp.GetById(id));
            return RedirectToAction("Index");
        }
    }
}
