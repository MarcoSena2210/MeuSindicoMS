using MeuSindicoMS.Domain.ValueObjects;
using System;

namespace MeuSindicoMS.Domain.Entities.Financeiro
{
    public class PagamentoDinheiro : Pagamento
    {
        public PagamentoDinheiro(string numeroRecibo,
            string numeroPagamentoInterno,
            string numeroMensalidade,
            decimal valor,
            decimal valorPago,
            DateTime dataVencimento,
            DateTime dataPagamento,
            CPFouCNPJ documento,
            string enderecoCobranca) : 
            base
            (numeroPagamentoInterno, 
             numeroMensalidade, 
             valor,
             valorPago,
             dataVencimento,
             dataPagamento,
             documento,
             enderecoCobranca)
        {
            NumeroRecibo = numeroRecibo;
        }

        public string NumeroRecibo { get; private set; }

        //public override bool EhValido()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
