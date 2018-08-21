using MeuSindicoMS.Domain.Core.Models;
using MeuSindicoMS.Domain.ValueObjects;
using MeuSindicoMS.Domain.ValueObjects;

namespace MeuSindicoMS.Domain.Entities.Administrativo
{
    public abstract class Pessoa :Entity 
    {
        protected Pessoa()
        {
        }

        protected Pessoa(Nome nome, CPFouCNPJ documento, Email email )
        {
            Nome = nome;
            Documento = documento;
            Email = email;

        }

        public Nome Nome { get; private set; }
        public CPFouCNPJ Documento { get; private set; }
        public Email Email { get; private set; }
       
    }

  
}
