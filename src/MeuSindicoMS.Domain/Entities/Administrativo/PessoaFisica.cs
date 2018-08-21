using MeuSindicoMS.Domain.ValueObjects;
using MeuSindicoMS.Domain.ValueObjects;

namespace MeuSindicoMS.Domain.Entities.Administrativo
{
    public class PessoaFisica : Pessoa
    {
        protected PessoaFisica(Nome nome, CPFouCNPJ documento, Email email) : base(nome, documento, email)
        {
        }

        public string Telefone { get; private set; }

        //public override bool EhValido()
        //{
        //    Validar();
        //    return ValidationResult.IsValid;
        //}

        //#region Validações
        //private void Validar()
        //{
         
        //    ValidationResult = Validate(this);

        //    // Validacoes adicionais 
        //    //ValidarEndereco();
        //}

      
        //#endregion
    }
}
