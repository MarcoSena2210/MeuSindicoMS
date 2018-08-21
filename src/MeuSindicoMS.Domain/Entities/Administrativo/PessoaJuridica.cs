using System;
using System.Collections.Generic;
using System.Text;
using MeuSindicoMS.Domain.ValueObjects;
using MeuSindicoMS.Domain.ValueObjects;

namespace MeuSindicoMS.Domain.Entities.Administrativo
{
    public class PessoaJuridica : Pessoa
    {
        protected PessoaJuridica(Nome nome, CPFouCNPJ documento, Email email)
                          : base(nome, documento, email)
        {
        }

        //public override bool EhValido()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
