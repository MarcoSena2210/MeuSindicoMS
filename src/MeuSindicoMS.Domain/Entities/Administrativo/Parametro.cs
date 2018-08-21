using MeuSindicoMS.Domain.Core.Models;
using MeuSindicoMS.Domain.Enums;
using System;

namespace MeuSindicoMS.Domain.Entities.Administrativo
{
    public class Parametro:Entity
    {
        public Parametro(Guid condominioId, Guid edificacaoId,
            byte numeroDeImoveisPorEdificio,
            byte diaVencimentoBoleto, 
            byte diaParaDesconto,
            ETipoCondominio tipoCondominio, ETipoJuro tipoJuro, 
            ETipoMulta tipoMulta, ETipoCobranca tipoFundoReserva,
            ETipoCobranca tipoDesconto, decimal percentuaJuro,
            decimal percentuaMulta, decimal percentuaFundoReserva, 
            decimal percentuaDesconto, decimal valorCondominio,
            decimal valorDesconto, decimal valorMulta, 
            decimal valorFundoReserva)
        {
            CondominioId = condominioId;
            EdificacaoId = edificacaoId;
            NumeroDeImoveisPorEdificio = numeroDeImoveisPorEdificio;
            DiaVencimentoBoleto = diaVencimentoBoleto;
            DiaParaDesconto = diaParaDesconto;
            TipoCondominio = tipoCondominio;
            TipoJuro = tipoJuro;
            TipoMulta = tipoMulta;
            TipoFundoReserva = tipoFundoReserva;
            TipoDesconto = tipoDesconto;
            PercentuaJuro = percentuaJuro;
            PercentuaMulta = percentuaMulta;
            PercentuaFundoReserva = percentuaFundoReserva;
            PercentuaDesconto = percentuaDesconto;
            ValorCondominio = valorCondominio;
            ValorDesconto = valorDesconto;
            ValorMulta = valorMulta;
            ValorFundoReserva = valorFundoReserva;
        }

        public Guid CondominioId { get; private set; }
        public Guid EdificacaoId { get; private set; }
        public byte NumeroDeImoveisPorEdificio { get; private set; }
        public byte DiaVencimentoBoleto { get; private set; }
        public byte DiaParaDesconto { get; private set; }

        public ETipoCondominio TipoCondominio { get; private set; }
        public ETipoJuro TipoJuro { get; private set; }
        public ETipoMulta TipoMulta { get; private set; }
        public ETipoCobranca TipoFundoReserva { get; private set; }
        public ETipoCobranca TipoDesconto { get; private set; }

        public decimal PercentuaJuro { get; private set; }
        public decimal PercentuaMulta { get; private set; }
        public decimal PercentuaFundoReserva { get; private set; }
        public decimal PercentuaDesconto { get; private set; }

        public decimal ValorCondominio { get; private set; }
        public decimal ValorDesconto { get; private set; }
        public decimal ValorMulta { get; private set; }
        public decimal ValorFundoReserva { get; private set; }

        //public override bool EhValido()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
