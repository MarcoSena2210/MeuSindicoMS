using MeuSindicoMS.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace MeuSindicoMS.Domain.Entities.Financeiro
{
    public class Mensalidade : Entity
    {
        public Mensalidade(string numeroMensalidade, string anoMesRefencia)
        {
            NumeroMensalidade = numeroMensalidade;
            AnoMesRefencia = anoMesRefencia;
        }

        public string NumeroMensalidade { get; private set; } //CD condominio+Codigo Edificio + Id Imovel+ AnoMensalidadeMes
        public string AnoMesRefencia { get; private set; }
        public DateTime DataGeracao { get; private set; }
        public DateTime? DataPagamento { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public decimal Valor { get; private set; }
        public Guid ImovelId { get; private set; }
        public Guid EdificacaolId { get; private set; }
        public List<RateioDespesa> RateioDespesas { get; private set; }
        public string Status { get; private set; }

        //public override bool EhValido()
        //{
        //    throw new NotImplementedException();
        //}
    }

}

  
