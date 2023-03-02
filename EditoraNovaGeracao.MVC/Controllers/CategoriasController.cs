using AutoMapper;
using EditoraNovaGeracao.Application.Interfaces;
using EditoraNovaGeracao.Domain.Entities;
using EditoraNovaGeracao.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EditoraNovaGeracao.MVC.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly ICategoriaAppService _categoriaApp;

        public CategoriasController(ICategoriaAppService service)
        {
            _categoriaApp = service;
        }

        private CategoriaViewModel GetViewModelById(Guid id)
        {
            var categoria = _categoriaApp.GetById(id);
            return Mapper.Map<Categoria, CategoriaViewModel>(categoria);
        }

        // GET: Categorias
        public ActionResult Index()
        {
            return View(Mapper.Map<IEnumerable<Categoria>, IEnumerable<CategoriaViewModel>>(_categoriaApp.GetAll()));
        }

        // GET: Categorias/Details/<GUID>
        public ActionResult Details(Guid id)
        {
            return View(GetViewModelById(id));
        }

        // GET: Categorias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categorias/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoriaViewModel categoria)
        {
            if (ModelState.IsValid)
            {
                _categoriaApp.Add(Mapper.Map<CategoriaViewModel, Categoria>(categoria));
                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        // GET: Categorias/Edit/<GUID>
        public ActionResult Edit(Guid id)
        {
            return View(GetViewModelById(id));
        }

        // POST: Categorias/Edit/<GUID>
        [HttpPost]
        public ActionResult Edit(CategoriaViewModel categoria)
        {
            if (ModelState.IsValid)
            {
                _categoriaApp.Update(Mapper.Map<CategoriaViewModel, Categoria>(categoria));
                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        // GET: Categorias/Delete/<GUID>
        public ActionResult Delete(Guid id)
        {
            return View(GetViewModelById(id));
        }

        // POST: Categorias/Delete/<GUID>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _categoriaApp.Remove(_categoriaApp.GetById(id));
            return RedirectToAction("Index");
        }
    }
}
