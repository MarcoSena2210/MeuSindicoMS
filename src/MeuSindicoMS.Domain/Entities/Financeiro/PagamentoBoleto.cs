using MeuSindicoMS.Domain.ValueObjects;
using System;

namespace MeuSindicoMS.Domain.Entities.Financeiro
{
    public  class PagamentoBoleto :Pagamento
    {
        public PagamentoBoleto(string boletoCodigoBarra, 
            string boletoNumero, string numeroPagamentoInterno,
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
            BoletoCodigoBarra = boletoCodigoBarra;
            BoletoNumero = boletoNumero;
        }

        public string BoletoCodigoBarra { get; private set; }
        public string BoletoNumero { get; private set; }

        //    public override bool EhValido()
        //    {
        //        throw new NotImplementedException();
        //    }
        //
    }
}
