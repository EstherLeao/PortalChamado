using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortalChamado.Models;

namespace PortalChamado.Data
{
    public class SeedingService
    {
        private PortalChamadoContext _context;

        public SeedingService(PortalChamadoContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Acesso.Any() ||
                _context.Usuario.Any() ||
                _context.Chamado.Any())
            {
                return; //DB já foi populado
            }

            Acesso a1 = new Acesso("Programador");
            Acesso a2 = new Acesso("Control");
            Acesso a3 = new Acesso("Supervisor");

            Usuario u1 = new Usuario(213579, "Esther Leão", "Programador", "senha", a1);

            _context.Acesso.AddRange(a1, a2, a3);
            _context.Usuario.Add(u1);

            _context.SaveChanges();
        }
    }
}
