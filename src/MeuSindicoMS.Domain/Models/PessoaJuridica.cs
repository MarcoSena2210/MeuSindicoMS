using MeuSindico.Domain.ValueObjects;
using MeuSindicoMS.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeuSindicoMS.Domain.Models
{
    public class PessoaJuridica :Pessoa : Entity

    {
        public string RazaoSocial { get; private set; }
        public string InscricaoEstadual { get; private set; }
        public Cnpj Cnpj { get; private set; }
    }
}
