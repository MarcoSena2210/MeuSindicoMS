using MeuSindicoMS.Domain.Enums;
using MeuSindicoMS.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeuSindicoMS.Domain.Entities
{
    public class Imovel : Entity
    {
        public Imovel(
            string identificadorImovel, 
            string sigla, 
            string numeroImovel, 
            EnumTipoImovel enumTipoImovel, 
            Pessoa responsavelFinanceiro, 
            Edificio edificioId)
        {
            IdentificadorImovel = identificadorImovel;
            Sigla = sigla;
            NumeroImovel = numeroImovel;
            EnumTipoImovel = enumTipoImovel;
            ResponsavelFinanceiro = responsavelFinanceiro;
            EdificioId = edificioId;
        }

        public string IdentificadorImovel { get; private set; }
        public string Sigla { get; private set; } //AP-apatamento;TR-Terreno;GA-Garagem;QD=Quadra;PI=Piscina;CA=CASA;LO=Loja
        public string NumeroImovel { get; private set; } //not null    
        public EnumTipoImovel EnumTipoImovel { get; private set; }
        public Pessoa ResponsavelFinanceiro { get; private set; }
        public Edificio EdificioId { get; private set; }
    }
}
