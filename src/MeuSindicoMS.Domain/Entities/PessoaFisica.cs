using MeuSindicoMS.Domain.Enums;
using MeuSindicoMS.Domain.ValueObjects;
using System;

namespace MeuSindicoMS.Domain.Entities
{
    public class PessoaFisica 
    {
        public Nome Nome { get; protected set; }
        public Email Email { get; protected set; }
        public EnumTipoPessoa EnumTipoPessoa { get; protected set; }
        public DateTime DataNascimento { get; private set; }
        public string RegistroIdentidade { get; private set; }
        public string TituloEleitor { get; private set; }
        public Endereco Endereco { get; private set; }
        public Cpf Cpf { get; private set; }
    }
}   
