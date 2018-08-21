using MeuSindicoMS.Domain.Core.Models;

namespace MeuSindicoMS.Domain.ValueObjects
{
    public class VEndereco : ValueObject
    {
        public VEndereco(string logradouro, string numero, string complemento, string bairro, string cep, string cidade, string estado)
        {

            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            CEP = cep;
            Cidade = cidade;
            Estado = estado;

         //   Valido();
         }

        // Construtor para o EF
        //protected VEndereco() { }

        //public bool Valido()
        //{
        //    AddNotifications(new Contract()
        //    .Requires()
        //    .HasMinLen(Logradouro, 5, "Endereco.Logradouro", "Logradouro deve conter pelo menos 5 caracteres")
        //    .HasMaxLen(Logradouro, 70, "Endereco.Logradouro", "Logradouro deve conter no máximo 70 caracteres")

        //    .HasMaxLen(Complemento, 50, "Endereco.Complemento", "Complemento deve conter no máximo 50 caracteres")
        //    .HasMaxLen(Numero, 10, "Endereco.Numero", "Numero deve conter no máximo 10 caracteres")


        //    .HasMinLen(Bairro, 5, "Endereco.Bairro", "Bairro deve conter pelo menos 5 caracteres")
        //    .HasMaxLen(Bairro, 70, "Endereco.Bairro", "Bairro deve conter no máximo 70 caracteres")

        //    .HasMinLen(Cidade, 5, "Endereco.Cidade", "Cidade deve conter pelo menos 5 caracteres")
        //    .HasMaxLen(Cidade, 50, "Endereco.Cidade", "Cidade deve conter no máximo 50 caracteres")

        //    .HasMaxLen(Estado, 2, "Endereco.Estado", "Estado deve conter 2 caracteres")

        //    .HasMaxLen(CEP, 8, "Endereco.CEP", "CEP deve conter 8 caracteres"));

        //     return Valid;
       

        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string CEP { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
    }
}
