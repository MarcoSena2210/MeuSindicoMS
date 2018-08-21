using MeuSindicoMS.Domain.ValueObjects;
using System;

namespace MeuSindicoMS.Domain.Entities.Financeiro
{
    public class PagamentoCartao :Pagamento
    {
        public PagamentoCartao(string titular,
            string numeroFinalCartao, 
            string numeroUltimaTransacao,
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
            Titular = titular;
            NumeroFinalCartao = numeroFinalCartao;
            NumeroUltimaTransacao = numeroUltimaTransacao;
        }

        public string Titular { get; private set; }
        public string NumeroFinalCartao { get; private set; } //4 ultimo digisto
        public string NumeroUltimaTransacao { get; private set; } //4 ultimo digisto

        //public override bool EhValido()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
