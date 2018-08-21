using MeuSindicoMS.Domain.Entities;
using MeuSindicoMS.Domain.Entities.Administrativo;
using MeuSindicoMS.Domain.ValueObjects;
using System;

namespace MeuSindicoMS.Domain.Arguments.Condominio
{ 
    public class AdicionarCondominioRequest
    {
        public string RazaoSocial { get; private set; }
        public string Nome { get; private set; }
        public Guid EmpresaId { get; private set; }
        public virtual Empresa Empresa { get; private set; }
        public Email Email { get; private set; }
        
        public string UrlLogo { get; private set; }
    }
}