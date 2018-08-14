using MeuSindicoMS.Domain.Entities;
using System;

namespace MeuSindicoMS.Domain.Arguments.Condominio
{ 
    public class AdicionarCondominioRequest
    {
        public string RazaoSocial { get; private set; }
        public string Nome { get; private set; }
        public Guid EmpresaId { get; private set; }
        public virtual Empresa Empresa { get; private set; }
        public string Email { get; private set; }
        
        public string UrlLogo { get; private set; }
    }
}