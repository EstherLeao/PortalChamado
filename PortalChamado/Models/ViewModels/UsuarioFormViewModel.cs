using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalChamado.Models.ViewModels
{
    public class UsuarioFormViewModel
    {
        public Usuario Usuario { get; set; }
        public ICollection<Acesso> Acessos { get; set; }
    }
}
