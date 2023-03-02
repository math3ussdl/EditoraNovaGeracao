using AutoMapper;
using EditoraNovaGeracao.Application.Interfaces;
using EditoraNovaGeracao.Domain.Entities;
using EditoraNovaGeracao.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EditoraNovaGeracao.MVC.Controllers
{
    public class FornecedoresController : Controller
    {
        private readonly IFornecedorAppService _fornecedorApp;

        public FornecedoresController(IFornecedorAppService service)
        {
            _fornecedorApp = service;
        }

        private FornecedorViewModel GetViewModelById(Guid id)
        {
            var fornecedor = _fornecedorApp.GetById(id);
            return Mapper.Map<Fornecedor, FornecedorViewModel>(fornecedor);
        }

        // GET: Fornecedores
        public ActionResult Index()
        {
            return View(Mapper.Map<IEnumerable<Fornecedor>, IEnumerable<FornecedorViewModel>>(_fornecedorApp.GetAll()));
        }

        // GET: Fornecedores/Details/<GUID>
        public ActionResult Details(Guid id)
        {
            return View(GetViewModelById(id));
        }

        // GET: Fornecedores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fornecedores/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FornecedorViewModel fornecedor)
        {
            if (ModelState.IsValid)
            {
                _fornecedorApp.Add(Mapper.Map<FornecedorViewModel, Fornecedor>(fornecedor));
                return RedirectToAction("Index");
            }

            return View(fornecedor);
        }

        // GET: Fornecedores/Edit/<GUID>
        public ActionResult Edit(Guid id)
        {
            return View(GetViewModelById(id));
        }

        // POST: Fornecedores/Edit/<GUID>
        [HttpPost]
        public ActionResult Edit(FornecedorViewModel fornecedor)
        {
            if (ModelState.IsValid)
            {
                _fornecedorApp.Update(Mapper.Map<FornecedorViewModel, Fornecedor>(fornecedor));
                return RedirectToAction("Index");
            }

            return View(fornecedor);
        }

        // GET: Fornecedores/Delete/<GUID>
        public ActionResult Delete(Guid id)
        {
            return View(GetViewModelById(id));
        }

        // POST: Fornecedores/Delete/<GUID>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _fornecedorApp.Remove(_fornecedorApp.GetById(id));
            return RedirectToAction("Index");
        }
    }
}
