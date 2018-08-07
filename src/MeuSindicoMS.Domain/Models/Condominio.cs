using MeuSindico.Domain.ValueObjects;
using System;

namespace MeuSindicoMS.Domain.Models
{
    public class Condominio
    {
        public string RazaoSocial { get; private set; }
        public Nome Nome { get; private set; }
        public Guid EmpresaId { get; private set; }
        public virtual Empresa Empresa { get; private set; }
        public Email Email { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string UrlLogo { get; private set; }

    }
}
