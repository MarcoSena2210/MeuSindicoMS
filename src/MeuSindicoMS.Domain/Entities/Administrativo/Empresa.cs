using MeuSindicoMS.Domain.Core.Models;

namespace MeuSindicoMS.Domain.Entities.Administrativo
{
    public class Empresa:Entity
    {
        public Empresa(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }

        public string Nome { get; private set; }
        public string Telefone { get; private set; }

        //public override bool EhValido()
        //{

        //    Validar();
        //    return ValidationResult.IsValid;
        //}


        //#region Validações
        //private void Validar()
        //{
        //    ValidarNome();
        //    ValidarTelefone();
        //    ValidationResult = Validate(this);
        //}

        //private void ValidarNome()
        //{
        //    RuleFor(c => c.Nome)
        //        .NotEmpty().WithMessage("O nome do condominio precisa ser fornecido")
        //        .Length(2, 150).WithMessage("O nome do condominio precisa ter entre 2 e 100 caracteres");
        //}

        //private void ValidarTelefone()
        //{
        //    RuleFor(c => c.Telefone)
        //        .NotEmpty().WithMessage("O telefone do condominio precisa ser fornecido")
        //        .Length(7, 25).WithMessage("O telefone do condominio precisa ter entre 7 e 25 caracteres");
        //}
        //#endregion

    }
}
