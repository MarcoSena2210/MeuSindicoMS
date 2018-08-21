using MeuSindicoMS.Domain.Core.Models;
using MeuSindicoMS.Domain.ValueObjects;
using MeuSindicoMS.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MeuSindicoMS.Domain.Entities.Administrativo
{
    public class Condominio : Entity
    {
        private IList<Edificacao> _edificacoes;
        
        public Condominio(string nome, Guid empresaId, string razaoSocial,
              Email email)
        {
            Nome = nome;
            EmpresaId = empresaId;
            RazaoSocial = razaoSocial;
            Email = email;
            _edificacoes = new List<Edificacao>();
        }

        public string Nome { get; private set; }
        public string RazaoSocial { get; private set; }
        public Email Email { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string UrlLogo { get; private set; }

        public Guid EmpresaId { get; private set; }
        // EF propriedades de navegacao
        public virtual Empresa Empresa { get; private set; }


        public IReadOnlyCollection<Edificacao> Edificacoes => _edificacoes.ToArray();

        public void AdicionaEdificacao(Edificacao edificacao)
        {
            _edificacoes.Add(edificacao);
        }

        //public override bool EhValido()
        //{
        //    Validar();
        //    return ValidationResult.IsValid;
        //}


        //#region Validações
        //private void Validar()
        //{
        //    ValidarNome();
        //    ValidarEmpresa();
        //    ValidarRazaoSocial();
        //    ValidationResult = Validate(this);

        //    // Validacoes adicionais 
        //    //ValidarEndereco();
        //}

        //private void ValidarNome()
        //{
        //    RuleFor(c => c.Nome)
        //        .NotEmpty().WithMessage("O nome do condominio precisa ser fornecido")
        //        .Length(2, 150).WithMessage("O nome do condominio precisa ter entre 2 e 100 caracteres");
        //}

        //private void ValidarEmpresa()
        //{
        //    RuleFor(c => c.EmpresaId)
        //        .Null().WithMessage("A empresa precisa ser informada");
        //}

        //private void ValidarRazaoSocial()
        //{
        //    RuleFor(c => c.RazaoSocial)
        //            .NotEmpty().WithMessage("A Razão Social precisa ser fornecido")
        //            .Length(2, 100).WithMessage("A Razão Social precisa ter entre 2 e 100 caracteres");
        //}
        //#endregion
    }
}
