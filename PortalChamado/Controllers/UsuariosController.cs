using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PortalChamado.Services;

namespace PortalChamado.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly UsuariosService _usuariosService;

        public UsuariosController(UsuariosService usuariosService)
        {
            _usuariosService = usuariosService;
        }

        public IActionResult Index()
        {
            var list = _usuariosService.FindAll();
            return View(list);
        }

    }
}