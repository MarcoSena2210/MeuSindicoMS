using MeuSindicoMS.Domain.ValueObjects;
using System;

namespace MeuSindicoMS.Domain.Entities.Financeiro
{
    public class PagamentoPayPal : Pagamento
    {
        public PagamentoPayPal(string codigoTransacaoPaypal, 
            string numeroPagamentoInterno,
            string numeroMensalidade,
            decimal valor,
            decimal valorPago,
            DateTime dataVencimento,
            DateTime dataPagamento,
            CPFouCNPJ documento,
            string enderecoCobranca) :base
            (numeroPagamentoInterno,
             numeroMensalidade,
             valor,
             valorPago,
             dataVencimento,
             dataPagamento,
             documento,
             enderecoCobranca)
        {
            CodigoTransacaoPaypal = codigoTransacaoPaypal;
        }

        public string CodigoTransacaoPaypal { get; private set; } //4 ultimo digisto

        //public override bool EhValido()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
