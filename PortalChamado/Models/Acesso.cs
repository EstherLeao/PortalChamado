using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalChamado.Models
{
    public class Acesso
    {
        [Key]
        public int IdAcesso { get; set; }
        public string TipoAcesso { get; set; }
    }
}
