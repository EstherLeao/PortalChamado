using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PortalChamado.Models.ViewModels;
using PortalChamado.Models;

namespace PortalChamado.Controllers
{
    public class AcessosController : Controller
    {
        public IActionResult Index()
        {
            List<Acesso> list = new List<Acesso>();
            list.Add(new Acesso { IdAcesso = 1, TipoAcesso = "Programador" });
            list.Add(new Acesso { IdAcesso = 2, TipoAcesso = "Control" });


            return View(list);
        }
    }
}