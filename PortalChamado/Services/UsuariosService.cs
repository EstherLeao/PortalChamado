using PortalChamado.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortalChamado.Models;

namespace PortalChamado.Services
{
    public class UsuariosService
    {
        private readonly PortalChamadoContext _context;

        public UsuariosService(PortalChamadoContext context)
        {
            _context = context;
        }

        public List<Usuario> FindAll()
        {
            return _context.Usuario.ToList();
        }

        public void Insert(Usuario obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
