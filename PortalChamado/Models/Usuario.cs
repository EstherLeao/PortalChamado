using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;

namespace PortalChamado.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public int Login { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Senha { get; set; }
        public Acesso Acesso { get; set; }
        public ICollection<Chamado> Chamado { get; set; } = new List<Chamado>();

        public Usuario()
        {

        }

        public Usuario(int login, string nome, string tipo, string senha, Acesso acesso)
        {
            Login = login;
            Nome = nome;
            Tipo = tipo;
            Senha = senha;
            Acesso = acesso;
        }


        public void AddChamdo(Chamado c)
        {
            Chamado.Add(c);
        }

        public void RemovChamado (Chamado c)
        {
            Chamado.Remove(c);
        }

        public double ContChamadoAbr (DateTime inicio, DateTime final)
        {
            return Chamado.Where(c => c.DataInicio >= inicio && c.DataInicio <= final).Sum(c => c.IdChamado);
        }
        public double ContChamadoRsp(DateTime inicio, DateTime final)
        {
            return Chamado.Where(c => c.DataResposta >= inicio && c.DataResposta <= final).Sum(c => c.IdChamado);
        }
    }
}
