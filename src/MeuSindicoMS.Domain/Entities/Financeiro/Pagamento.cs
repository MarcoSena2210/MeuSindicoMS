using MeuSindicoMS.Domain.Core.Models;
using MeuSindicoMS.Domain.ValueObjects;
using System;

namespace MeuSindicoMS.Domain.Entities.Financeiro
{
    public abstract class Pagamento : Entity
    {
        private CPFouCNPJ documento;

        protected Pagamento()
        {
        }

        protected Pagamento(string numeroPagamentoInterno, 
            string numeroMensalidade,
            decimal valor,
            decimal valorPago,
            DateTime dataVencimento, 
            DateTime dataPagamento,
            string documento, 
            string enderecoCobranca)
        {
            NumeroPagamentoInterno = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            NumeroMensalidade = numeroMensalidade;
            Valor = valor;
            ValorPago = valorPago;
            DataVencimento = dataVencimento;
            DataPagamento = dataPagamento;
            Documento = documento;
            EnderecoCobranca = enderecoCobranca;
        }

        protected Pagamento(string numeroPagamentoInterno, string numeroMensalidade, decimal valor, decimal valorPago, DateTime dataVencimento, DateTime dataPagamento, CPFouCNPJ documento, string enderecoCobranca)
        {
            NumeroPagamentoInterno = numeroPagamentoInterno;
            NumeroMensalidade = numeroMensalidade;
            Valor = valor;
            ValorPago = valorPago;
            DataVencimento = dataVencimento;
            DataPagamento = dataPagamento;
            this.documento = documento;
            EnderecoCobranca = enderecoCobranca;
        }

        public string NumeroPagamentoInterno { get; set; }
        public string NumeroMensalidade { get; private set; } //CD condominio+Codigo Edificio + Id Imovel+ AnoMensalidadeMes
        public decimal Valor { get; private set; }
        public decimal ValorPago { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public DateTime DataPagamento { get; private set; }
        public string Documento  { get; private set; } //Usado para emitir nota fiscal
        public string EnderecoCobranca { get; private set; } //
        public string Email {  get; private set;  }

    }
    
}
