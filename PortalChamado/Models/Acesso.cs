using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;

namespace PortalChamado.Models
{
    public class Acesso
    {
        [Key]
        public int IdAcesso { get; set; }
        public string TipoAcesso { get; set; }
        public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();


        public Acesso()
        {

        }
        public Acesso(string tipoAcesso)
        {
            TipoAcesso = tipoAcesso;
        }

        public void AddUsuario (Usuario u)
        {
            Usuarios.Add(u);
        }
        
        public double ContChamadoAbr(DateTime inicial, DateTime final)
        {
            return Usuarios.Sum(usuario => usuario.ContChamadoAbr(inicial, final));
        }

        public double ContChamadoRsp(DateTime inicial, DateTime final)
        {
            return Usuarios.Sum(usuario => usuario.ContChamadoRsp(inicial, final));
        }

    }
}
