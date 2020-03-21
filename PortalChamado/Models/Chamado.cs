﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using PortalChamado.Models.Enums;

namespace PortalChamado.Models
{
    public class Chamado
    {
        [Key]
        public int IdChamado { get; set; }
        public string LoginCriador { get; set; }
        public int Carteira { get; set; }
        public int Quantidade{ get; set; }
        public string LoginTratamento { get; set; }
        public string Texto { get; set; }
        public string Assunto { get; set; }
        public Enums.ChamadoImportancia Importancia { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataResposta { get; set; }
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
