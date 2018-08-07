using MeuSindico.Domain.Enums;
using MeuSindico.Domain.ValueObjects;
using System;

namespace MeuSindicoMS.Domain.Models
{
    public class PessoaFisica :Pessoa
    {
        public PessoaFisica(Nome nome,
            Email email,
            EnumTipoPessoa enumTipoPessoa,
            DateTime dataNascimento,
            string registroIdentidade, 
            string tituloEleitor, 
            Endereco endereco,
            Cpf cpf)
        {
            Nome = nome;
            Email = email;
            EnumTipoPessoa = enumTipoPessoa;
            DataNascimento = dataNascimento;
            RegistroIdentidade = registroIdentidade;
            TituloEleitor = tituloEleitor;
            Endereco = endereco;
            Cpf = cpf;
        }

        public Nome Nome { get; private set; }
        public Email Email { get; private set; }
        public EnumTipoPessoa EnumTipoPessoa { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string RegistroIdentidade { get; private set; }
        public string TituloEleitor { get; private set; }
        public Endereco Endereco { get; private set; }
        public Cpf Cpf { get; private set; }
    }
}   
