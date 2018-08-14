using MeuSindicoMS.Domain.ValueObjects;
using MeuSindicoMS.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeuSindicoMS.Domain.Entities
{
    public class PessoaJuridica :Pessoa 

    {
        public string RazaoSocial { get; private set; }
        public string InscricaoEstadual { get; private set; }
        public Cnpj Cnpj { get; private set; }
    }
}
