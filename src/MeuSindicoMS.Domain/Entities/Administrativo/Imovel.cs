using MeuSindicoMS.Domain.Core.Models;
using System;

namespace MeuSindicoMS.Domain.Entities.Administrativo
{
    public class Imovel : Entity
    {
        public Imovel(string identificadorImovel,
            string sigla, string numero,
            Guid pessoaFisicaId, Guid condominioId, Guid edificacaolId)
        {
            IdentificadorImovel = identificadorImovel;
            Sigla = sigla;
            Numero = numero;
            PessoaFisicaId = pessoaFisicaId;
            CondominioId = condominioId;
            EdificacaoId = EdificacaoId;
        }

        public string IdentificadorImovel { get; private set; } //not null  
        public string Sigla { get; private set; } //AP-apatamento;TR-Terreno;GA-Garagem;QD=Quadra;PI=Piscina;CA=CASA;LO=Loja
        public string Numero { get; private set; }   
        //public ETipoImovel EnumTipoImovel { get; private set; }

        public Guid PessoaFisicaId { get; private set; }
        public Guid CondominioId { get; private set; }
        public Guid EdificacaoId { get; private set; }
        public virtual Condominio Condominio { get; private set; }
        public virtual PessoaFisica MoradorResponsavel { get; private set; }
        public virtual Edificacao Edificacao { get; private set; }

        //public override bool EhValido()
        //{
        //    Validar();
        //    return ValidationResult.IsValid;
        //}


        //#region Validações
        //private void Validar()
        //{
        //    ValidarIdentificadorImovel();
        //    ValidarSigla();
        //    ValidarNumero();
        //    ValidarCondominio();
        //    ValidarEdificacao();
        //    ValidarMoradorResponsavel();
        //    ValidationResult = Validate(this);

        //    // Validacoes adicionais 
        //    //ValidarEndereco();
        //}

        //private void ValidarIdentificadorImovel()
        //{
        //    RuleFor(c => c.IdentificadorImovel)
        //        .NotEmpty().WithMessage("O identificador do imóvel precisa ser fornecido")
        //        .Length(6, 10).WithMessage("O identificador do imóvel precisa ter entre 6 e 10 caracteres");
        //}

        //private void ValidarSigla()
        //{
        //    RuleFor(c => c.Sigla)
        //        .Length(2).WithMessage("A sigla precisa ter 2 caracteres");
        //}
  
        //private void ValidarNumero()
        //{
        //    RuleFor(c => c.Numero)
        //            .Length(4).WithMessage("O número precisa ter 2 caracteres");
        //}

        //private void ValidarCondominio()
        //{
        //    RuleFor(c => c.CondominioId)
        //            .Empty().WithMessage("O cóndominio precisa ter 2 caracteres");

        //}
        //private void ValidarEdificacao()
        //{ 
        //    RuleFor(c => c.EdificacaoId)
        //            .Empty().WithMessage("O cóndominio precisa ter 2 caracteres");

        //}
        //private void ValidarMoradorResponsavel()
        //{
        //    RuleFor(c => c.PessoaFisicaIdId)
        //            .Empty().WithMessage("O cóndominio precisa ter 2 caracteres");

        //}

        //#endregion
    }
}
