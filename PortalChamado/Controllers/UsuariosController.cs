using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PortalChamado.Models;
using PortalChamado.Models.ViewModels;
using PortalChamado.Services;

namespace PortalChamado.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly UsuariosService _usuarioService;
        private readonly AcessoService _acessoService;

        public UsuariosController(UsuariosService usuarioService, AcessoService acessoService)
        {
            _usuarioService = usuarioService;
            _acessoService = acessoService;
        }

        public IActionResult Index()
        {
            var list = _usuarioService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var acessos = _acessoService.FindAll();
            var viewModel = new UsuarioFormViewModel
            {
                Acessos = acessos
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Usuario usuario)
        {
            _usuarioService.Insert(usuario);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var obj = _usuarioService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _usuarioService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

    }
}