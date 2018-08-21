using MeuSindicoMS.Domain.ValueObjects;
using MeuSindicoMS.Domain.ValueObjects;
using System;


namespace MeuSindicoMS.Domain.Entities.Administrativo
{
    public class Morador : PessoaFisica
    {
        protected Morador(Nome nome, CPFouCNPJ documento, Email email) : base(nome, documento, email)
        {
        }

        public bool AtivoSN { get; private set; }
        public Guid ImovelId { get; private set; }

    }
}
