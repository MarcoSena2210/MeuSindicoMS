using MeuSindico.Domain.Enums;
using MeuSindico.Domain.ValueObjects;
using MeuSindicoMS.Domain.Core.Models;

namespace MeuSindicoMS.Domain.Models
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