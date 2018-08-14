using MeuSindicoMS.Domain.Enums;
using MeuSindicoMS.Domain.ValueObjects;
using MeuSindicoMS.Domain.Core.Models;

namespace MeuSindicoMS.Domain.Entities
{
    public abstract class Pessoa :Entity
    {
        public Pessoa(Nome nome, Email email, EnumTipoPessoa enumTipoPessoa)
        {
            Nome = nome;
            Email = email;
            EnumTipoPessoa = enumTipoPessoa;
        }

        public Nome Nome { get; protected set; }
        public Email Email { get; protected set; }
        public EnumTipoPessoa EnumTipoPessoa { get; protected set; }
    }
}