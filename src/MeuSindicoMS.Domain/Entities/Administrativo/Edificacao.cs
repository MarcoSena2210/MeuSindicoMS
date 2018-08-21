using MeuSindicoMS.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace MeuSindicoMS.Domain.Entities.Administrativo
{
    public class Edificacao : Entity
    {

        private readonly IList<Imovel> _imoveis;

        public Edificacao(
            string nome,
            string logradouro, 
            string numero,
            string complemento,
            string bairro,
            string cEP,
            string cidade,
            string estado,
            Guid condominioId)
        {
            Nome = nome;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            CEP = cEP;
            Cidade = cidade;
            Estado = estado;
            CondominioId = condominioId;
            _imoveis = new List<Imovel>();

        }

        #region Propriedade
        public string Nome { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string CEP { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public Guid CondominioId { get; private set; }
        public virtual Condominio Condominio { get; private set; }
        #endregion Propriedade

        //public void AdicionaTodosImoveis(byte quantidadeApartamento, Imovel objImovel)
        //{
        //    if (objImovel == null)
        //    {

        //        for (int i = 0; i < quantidadeApartamento; i++)
        //        {
        //            objImovel = new Imovel("AP" + i);
        //            _imoveis.Add(objImovel);
        //        }
        //    }
        //}


        //public override bool EhValido()
        //{
        //    Validar();
        //    return ValidationResult.IsValid;
        //}


        //#region Validações
        //private void Validar()
        //{
        //    ValidarNome();
        //    ValidarLogradouro();
        //    ValidarComplemento();
        //    ValidarNumero();
        //    ValidarBairro();
        //    ValidarCEP();
        //    ValidarCidade();
        //    ValidarEstado();
        //    ValidaCondominio();
        //    ValidationResult = Validate(this);

        //}


        //private void ValidarNome()
        //{
        //    RuleFor(c => c.Nome)
        //        .NotEmpty().WithMessage("O nome do condominio precisa ser fornecido")
        //        .Length(2, 150).WithMessage("O nome do condominio precisa ter entre 2 e 100 caracteres");
        //}

        //public void ValidarLogradouro()
        //{
        //    RuleFor(c => c.Logradouro)
        //        .NotEmpty().WithMessage("O Logradouro precisa ser fornecido")
        //        .Length(2, 80).WithMessage("O Logradouro precisa ter entre 2 e 80 caracteres");
        //}

        //public void ValidarComplemento()
        //{
        //    RuleFor(c => c.Complemento)
        //        .NotEmpty().WithMessage("O Logradouro precisa ser fornecido")
        //        .Length(2, 80).WithMessage("O Logradouro precisa ter entre 2 e 80 caracteres");
        //}

        //public void ValidarNumero()
        //{
        //    RuleFor(c => c.Numero)
        //        .NotEmpty().WithMessage("O Numero precisa ser fornecido")
        //        .Length(1, 10).WithMessage("O Numero precisa ter entre 1 e 10 caracteres");
        //}

        //public void ValidarBairro()
        //{
        //    RuleFor(c => c.Bairro)
        //        .NotEmpty().WithMessage("O Bairro precisa ser fornecido")
        //        .Length(2, 150).WithMessage("O Bairro precisa ter entre 2 e 150 caracteres");
        //}

        //public void ValidarCEP() 
        //{
        //    RuleFor(c => c.CEP)
        //        .NotEmpty().WithMessage("O CEP precisa ser fornecido")
        //        .Length(8).WithMessage("O CEP precisa ter 8 caracteres");
        //}

        //public void ValidarCidade()
        //{    RuleFor(c => c.Cidade)
        //        .NotEmpty().WithMessage("A Cidade precisa ser fornecida")
        //        .Length(2, 150).WithMessage("A Cidade precisa ter entre 2 e 150 caracteres");
        //}

        //public void ValidarEstado()
        //{
        //    RuleFor(c => c.Estado)
        //        .NotEmpty().WithMessage("O Estado precisa ser fornecido")
        //        .Length(2, 150).WithMessage("O Estado precisa ter entre 2 e 150 caracteres");
        //}

        //private void ValidaCondominio()
        //{
        //    RuleFor(c => c.CondominioId)
        //        .Empty().Null().WithMessage("O condominio é obrigatorio");

        //    if (CondominioId != null) {
        //        //Verificar se o condominio existe
        //    }
        //}
        //#endregion




    }
}
