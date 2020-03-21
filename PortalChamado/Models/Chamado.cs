using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using PortalChamado.Models.Enums;

namespace PortalChamado.Models
{
    public class Chamado
    {
        [Key]
        public int IdChamado { get; set; }
        [Display(Name = "Login")]
        public string LoginCriador { get; set; }
        public int Carteira { get; set; }
        public int Quantidade{ get; set; }
        [Display(Name = "Login de Tratamento")]
        public string LoginTratamento { get; set; }
        [Display(Name = "Descrição do Chamado")]
        public string Texto { get; set; }
        [Display(Name = "Assunto do Chamado")]
        public string Assunto { get; set; }
        [Display(Name = "Urgência")]
        public Enums.ChamadoImportancia Importancia { get; set; }
        [Display(Name = "Data de Criação")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime DataInicio { get; set; }
        [Display(Name = "Data de Tratamento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime DataResposta { get; set; }
        [Display(Name = "Status")]
        public Enums.ChamadoStatus Status { get; set; }
        public Usuario Usuario { get; set; }

        public Chamado()
        {

        }

        public Chamado(string loginCriador, int carteira, int quantidade, string loginTratamento, string texto, string assunto, ChamadoImportancia importancia, DateTime dataInicio, DateTime dataResposta, ChamadoStatus status, Usuario usuario)
        {
            LoginCriador = loginCriador;
            Carteira = carteira;
            Quantidade = quantidade;
            LoginTratamento = loginTratamento;
            Texto = texto;
            Assunto = assunto;
            Importancia = importancia;
            DataInicio = dataInicio;
            DataResposta = dataResposta;
            Status = status;
            Usuario = usuario;
        }

    }
}
