using PortalChamado.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortalChamado.Models;
using Microsoft.EntityFrameworkCore;
using PortalChamado.Services.Exceptions;

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

        public Usuario FindById(int id)
        {
            return _context.Usuario.Include(obj => obj.Acesso).FirstOrDefault(obj => obj.IdUsuario == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Usuario.Find(id);
            _context.Usuario.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Usuario obj)
        {
            if(!_context.Usuario.Any(x => x.IdUsuario == obj.IdUsuario))
            {
                throw new NotFoundException("Id não encontrado");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch(DBConcurrencyException e)
            {
                throw new DBConcurrencyException(e.Message);
            }

        }
    }
}
