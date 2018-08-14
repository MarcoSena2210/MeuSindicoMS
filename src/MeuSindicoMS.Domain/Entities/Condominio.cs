using MeuSindicoMS.Domain.ValueObjects;
using MeuSindicoMS.Domain.Core.Models;
using System;

namespace MeuSindicoMS.Domain.Entities
{
    public class Condominio : Entity
    {
        public string RazaoSocial { get; private set; }
        public string Nome { get; private set; }
        public Guid EmpresaId { get; private set; }
        public virtual Empresa Empresa { get; private set; }
        public Email Email { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string UrlLogo { get; private set; }

    }
}
