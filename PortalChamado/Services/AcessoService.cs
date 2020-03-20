using PortalChamado.Data;
using PortalChamado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalChamado.Services
{
    public class AcessoService
    {
        private readonly PortalChamadoContext _context;

        public AcessoService(PortalChamadoContext context)
        {
            _context = context;
        }

        public List<Acesso> FindAll()
        {
            return _context.Acesso.OrderBy(x => x.TipoAcesso).ToList();

        }
    }
}
